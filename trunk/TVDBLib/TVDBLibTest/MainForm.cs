﻿#region License Information (GPL v2)
/*
    TVDBLibTest - C# Library for TVDB Services
    Copyright (C) 2009  TVDBLibTest Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
    
    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using TVDBLib;

namespace TVDBLibTest
{
    public partial class MainForm : Form
    {
        private TVDB tvdb;
        SeriesFull seriesCache;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tvdb = new TVDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TVDB Cache"));
            tvdb.Debug += new TVDB.StringEventHandler(tvdb_Debug);
            tvdb.CacheWorking = true;
            LoadSettings();
            tvdb.CheckUpdates();
        }

        private void tvdb_Debug(string text)
        {
            txtConsole.AppendText(text + "\r\n");
            txtConsole.ScrollToCaret();
        }

        private void LoadSettings()
        {
            List<Language> languages = tvdb.GetLanguages();
            lvLanguages.Items.Clear();
            foreach (Language language in languages)
            {
                ListViewItem lvi = new ListViewItem(language.Name);
                lvi.SubItems.AddRange(new string[] { language.Abbreviation, language.ID });
                lvi.Tag = language;
                lvLanguages.Items.Add(lvi);
            }

            List<Mirror> mirrors = tvdb.GetMirrors();
            lvMirrors.Items.Clear();
            foreach (Mirror mirror in mirrors)
            {
                ListViewItem lvi = new ListViewItem(mirror.ID);
                lvi.SubItems.AddRange(new string[] { mirror.MirrorPath, mirror.TypeMask.ToString() });
                lvi.Tag = mirror;
                lvMirrors.Items.Add(lvi);
            }
        }

        private void lvLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLanguages.SelectedItems.Count > 0)
            {
                tvdb.ActiveLanguage = ((Language)lvLanguages.SelectedItems[0].Tag).Abbreviation;
            }
        }

        private void lvMirrors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMirrors.SelectedItems.Count > 0)
            {
                tvdb.ActiveMirror = ((Mirror)lvMirrors.SelectedItems[0].Tag).MirrorPath;
            }
        }

        private void btnSearchSeries_Click(object sender, EventArgs e)
        {
            List<Series> series = tvdb.GetSeriesList(txtSearchSeries.Text, tvdb.ActiveLanguage);
            lvSeries.Items.Clear();
            foreach (Series serie in series)
            {
                ListViewItem lvi = new ListViewItem(serie.SeriesName);
                lvi.SubItems.Add(serie.FirstAired);
                lvi.Tag = serie;
                lvSeries.Items.Add(lvi);
            }
            AutoSizeColumns();
        }

        private void AutoSizeColumns()
        {
            lvSeries.Columns[1].Width = lvSeries.ClientSize.Width - lvSeries.Columns[0].Width;
        }

        private void lvSeries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSeries.SelectedItems.Count > 0)
            {
                seriesCache = tvdb.GetSeriesFullInformation(((Series)lvSeries.SelectedItems[0].Tag).ID.ToString(), FileType.ZIP);
                plvSeries.SelectedObject = seriesCache.Series;
                FillEpisodes(seriesCache.Episodes);
                FillBanners(seriesCache.Banners);
            }
        }

        private void FillBanners(List<Banner> banners)
        {
            lvBanners.Items.Clear();
            foreach (Banner banner in seriesCache.Banners)
            {
                lvBanners.Items.Add(banner.BannerPath).Tag = banner;
            }
        }

        private void FillEpisodes(List<Episode> episodes)
        {
            tvEpisodes.Nodes.Clear();
            bool found = false;
            foreach (Episode episode in episodes)
            {
                foreach (TreeNode seasonNode in tvEpisodes.Nodes)
                {
                    if ((string)seasonNode.Tag == episode.SeasonNumber)
                    {
                        seasonNode.Nodes.Add(episode.EpisodeNumber + " - " + episode.EpisodeName).Tag = episode;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    TreeNode seasonNode = tvEpisodes.Nodes.Add("Season " + episode.SeasonNumber);
                    seasonNode.Tag = episode.SeasonNumber;
                    seasonNode.Nodes.Add(episode.EpisodeNumber + " - " + episode.EpisodeName).Tag = episode;
                }
                found = false;
            }
            tvEpisodes.ExpandAll();
        }

        private void lvSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSeries.SelectedItems.Count > 0)
            {
                plvSeries.SelectedObject = (Series)lvSeries.SelectedItems[0].Tag;
            }
        }

        private void tvEpisodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEpisodes.SelectedNode.Tag.GetType() == typeof(Episode))
            {
                plvEpisodes.SelectedObject = (Episode)tvEpisodes.SelectedNode.Tag;
            }
        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            if (seriesCache != null)
            {
                FillEpisodes(seriesCache.Episodes.SearchEpisode(txtEpisodeName.Text, txtSeasonNumber.Text, txtEpisodeNumber.Text));
            }
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void lvBanners_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBanners.SelectedItems.Count > 0)
            {
                Banner banner = (Banner)lvBanners.SelectedItems[0].Tag;
                plvBanners.SelectedObject = banner;
                pbBanner.ImageLocation = tvdb.GetBannerPath(banner.BannerPath);
            }
        }
    }
}