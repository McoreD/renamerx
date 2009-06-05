﻿#region License Information (GPL v2)
/*
    TVDBLib - C# Library for TVDB Services
    Copyright (C) 2009  TVDBLib Developers

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
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Zip;
using System.Net;

namespace TVDBLib
{
    public class TVDB
    {
        private const string APIKey = "90EAA040C265FB5D";

        public string ActiveMirror = "http://thetvdb.com";
        public string ActiveLanguage = "en";
        public TVDBCache Cache;

        public event StringEventHandler Debug;
        public delegate void StringEventHandler(string text);

        public bool CacheWorking
        {
            get
            {
                return cacheWorking;
            }
            set
            {
                cacheWorking = value;
                Cache.CacheLoad = Cache.CacheSave = value;
            }
        }

        private bool cacheWorking;

        public TVDB(string path)
        {
            Cache = new TVDBCache(path);
        }

        private void ConsoleWriteLine(string text)
        {
            Debug(text);
        }

        public void CheckUpdates()
        {
            if (CacheWorking)
            {
                string time = Cache.LoadTime();
                if (string.IsNullOrEmpty(time))
                {
                    GetTime();
                }
                else
                {
                    Updates updates = GetUpdates(time, UpdatesType.Series);
                    foreach (string seriesid in updates.Series)
                    {
                        if (Cache.SeriesExist(seriesid, ActiveLanguage))
                        {
                            ConsoleWriteLine("Update found: " + seriesid);
                            DownloadSeriesFull(seriesid, FileType.ZIP);
                        }
                    }
                }
            }
        }

        //http://thetvdb.com/api/GetSeries.php?seriesname=Lost
        public List<Series> GetSeriesList(string seriesName)
        {
            string path = string.Format("{0}/api/GetSeries.php?seriesname={1}", ActiveMirror, seriesName);
            ConsoleWriteLine("GetSeriesList: " + path);
            return ParseSeries(path);
        }

        //http://thetvdb.com/api/GetSeries.php?seriesname=Lost&language=en
        public List<Series> GetSeriesList(string seriesName, string language)
        {
            string path = string.Format("{0}/api/GetSeries.php?seriesname={1}&language={2}", ActiveMirror, seriesName, language);
            ConsoleWriteLine("GetSeriesList: " + path);
            return ParseSeries(path);
        }

        //http://thetvdb.com/api/90EAA040C265FB5D/series/73739/en.xml
        public Series GetSeriesInformation(string seriesid)
        {
            Series series = new Series();
            string path = string.Format("{0}/api/{1}/series/{2}/{3}.xml", ActiveMirror, APIKey, seriesid, ActiveLanguage);
            ConsoleWriteLine("GetSeriesInformation: " + path);
            try
            {
                XDocument xml = Cache.CheckSeries(path, seriesid, ActiveLanguage);
                series = ParseSerie(xml.Element("Data").Element("Series"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return series;
        }

        //http://thetvdb.com/api/90EAA040C265FB5D/series/73739/banners.xml
        public void GetBanners(string seriesid) //TODO
        {
            string path = string.Format("{0}/api/{1}/series/{2}/banners.xml", ActiveMirror, APIKey, seriesid);
        }

        //http://thetvdb.com/api/90EAA040C265FB5D/series/73739/default/2/13/en.xml
        public Episode GetEpisodeInformation(string seriesid, string seasonNumber, string episodeNumber)
        {
            Episode episode = new Episode();
            string path = string.Format("{0}/api/{1}/series/{2}/default/{3}/{4}/{5}.xml", ActiveMirror, APIKey, seriesid, seasonNumber, episodeNumber, ActiveLanguage);
            ConsoleWriteLine("GetEpisodeInformation: " + path);
            try
            {
                XDocument xml = XDocument.Load(path);
                episode = ParseEpisode(xml.Element("Data").Element("Episode"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return episode;
        }

        //http://thetvdb.com/api/90EAA040C265FB5D/series/73739/all/en.xml
        //http://thetvdb.com/api/90EAA040C265FB5D/series/73739/all/en.zip
        public SeriesAll GetSeriesFullInformation(string seriesid, FileType fileType)
        {
            try
            {
                XDocument xml = DownloadSeriesFull(seriesid, fileType);
                Series series = ParseSerie(xml.Descendants("Series").ElementAt(0));
                List<Episode> episodes = ParseEpisodes(xml);
                return new SeriesAll(series, episodes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        private XDocument DownloadSeriesFull(string seriesid, FileType fileType)
        {
            string path = string.Format("{0}/api/{1}/series/{2}/all/{3}.{4}", ActiveMirror, APIKey, seriesid, ActiveLanguage, fileType.ToString().ToLowerInvariant());
            ConsoleWriteLine("DownloadSeriesFull: " + path);
            return Cache.CheckSeriesFull(path, seriesid, ActiveLanguage);
        }

        //http://thetvdb.com/api/90EAA040C265FB5D/languages.xml
        public List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            string path = string.Format("{0}/api/{1}/languages.xml", ActiveMirror, APIKey);
            ConsoleWriteLine("GetLanguages: " + path);
            try
            {
                XDocument xml = Cache.CheckLanguages(path);
                foreach (XElement language in xml.Descendants("Language"))
                {
                    string name = language.ToString("name");
                    string abbreviation = language.ToString("abbreviation");
                    string id = language.ToString("id");
                    languages.Add(new Language { Name = name, Abbreviation = abbreviation, ID = id });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return languages.OrderBy(language => int.Parse(language.ID)).ToList<Language>();
        }

        //http://thetvdb.com/api/90EAA040C265FB5D/mirrors.xml
        public List<Mirror> GetMirrors()
        {
            List<Mirror> mirrors = new List<Mirror>();
            string path = string.Format("{0}/api/{1}/mirrors.xml", ActiveMirror, APIKey);
            ConsoleWriteLine("GetMirrors: " + path);
            try
            {
                XDocument xml = Cache.CheckMirrors(path);
                foreach (XElement mirror in xml.Descendants("Mirror"))
                {
                    string id = mirror.ToString("id");
                    string mirrorPath = mirror.ToString("mirrorpath");
                    string typeMask = mirror.ToString("typemask");
                    mirrors.Add(new Mirror { ID = id, MirrorPath = mirrorPath, TypeMask = typeMask });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return mirrors;
        }

        //http://www.thetvdb.com/api/Updates.php?type=none
        public string GetTime()
        {
            return GetUpdates("", UpdatesType.None).Time;
        }

        //http://www.thetvdb.com/api/Updates.php?time=1243914332&type=all
        public Updates GetUpdates(string time, UpdatesType type)
        {
            Updates updates = new Updates();
            string path = string.Format("{0}/api/Updates.php?time={1}&type={2}", ActiveMirror, time, type.ToString().ToLowerInvariant());
            ConsoleWriteLine("GetUpdates: " + path);
            try
            {
                XElement xml = XDocument.Load(path).Element("Items");
                foreach (XElement update in xml.Elements("Time"))
                {
                    updates.Time = update.Value;
                    Cache.SaveTime(updates.Time);
                    break;
                }
                foreach (XElement update in xml.Elements("Series"))
                {
                    updates.Series.Add(update.Value);
                }
                foreach (XElement update in xml.Elements("Episode"))
                {
                    updates.Episodes.Add(update.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return updates;
        }

        #region Private Methods

        private List<Series> ParseSeries(string path)
        {
            return ParseSeries(XDocument.Load(path));
        }

        private List<Series> ParseSeries(XDocument xml)
        {
            List<Series> series = new List<Series>();
            foreach (XElement serie in xml.Descendants("Series"))
            {
                series.Add(ParseSerie(serie));
            }
            return series;
        }

        private Series ParseSerie(XElement xe)
        {
            Series series = new Series();
            series.ID = xe.ToString("id");
            series.Actors = xe.ToString("Actors");
            series.AirsDayOfWeek = xe.ToString("Airs_DayOfWeek");
            series.AirsTime = xe.ToString("Airs_Time");
            series.ContentRating = xe.ToString("ContentRating");
            series.FirstAired = xe.ToString("FirstAired");
            series.Genre = xe.ToString("Genre");
            series.IMDB_ID = xe.ToString("IMDB_ID");
            series.Language = xe.ToString("Language");
            series.Network = xe.ToString("Network");
            series.NetworkID = xe.ToString("NetworkID");
            series.Overview = xe.ToString("Overview");
            series.Rating = xe.ToString("Rating");
            series.Runtime = xe.ToString("Runtime");
            series.SeriesID = xe.ToString("SeriesID");
            series.SeriesName = xe.ToString("SeriesName");
            series.Status = xe.ToString("Status");
            series.Added = xe.ToString("added");
            series.AddedBy = xe.ToString("addedBy");
            series.Banner = xe.ToString("banner");
            series.Fanart = xe.ToString("fanart");
            series.LastUpdated = xe.ToString("lastupdated");
            series.Poster = xe.ToString("poster");
            series.Zap2ItID = xe.ToString("zap2it_id");
            return series;
        }

        private List<Episode> ParseEpisodes(string path)
        {
            return ParseEpisodes(XDocument.Load(path));
        }

        private List<Episode> ParseEpisodes(XDocument xml)
        {
            List<Episode> episodes = new List<Episode>();
            try
            {
                foreach (XElement episode in xml.Descendants("Episode"))
                {
                    episodes.Add(ParseEpisode(episode));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return episodes;
        }

        private Episode ParseEpisode(XElement xe)
        {
            Episode episode = new Episode();
            episode.ID = xe.ToString("id");
            episode.Combined_EpisodeNumber = xe.ToString("Combined_episodenumber");
            episode.Combined_Season = xe.ToString("Combined_season");
            episode.DVD_Chapter = xe.ToString("DVD_chapter");
            episode.DVD_DiscID = xe.ToString("DVD_discid");
            episode.DVD_EpisodeNumber = xe.ToString("DVD_episodenumber");
            episode.DVD_Season = xe.ToString("DVD_season");
            episode.Director = xe.ToString("Director");
            episode.EpImgFlag = xe.ToString("EpImgFlag");
            episode.EpisodeName = xe.ToString("EpisodeName");
            episode.EpisodeNumber = xe.ToString("EpisodeNumber");
            episode.FirstAired = xe.ToString("FirstAired");
            episode.GuestStars = xe.ToString("GuestStars");
            episode.IMDB_ID = xe.ToString("IMDB_ID");
            episode.Language = xe.ToString("Language");
            episode.Overview = xe.ToString("Overview");
            episode.ProductionCode = xe.ToString("ProductionCode");
            episode.Rating = xe.ToString("Rating");
            episode.SeasonNumber = xe.ToString("SeasonNumber");
            episode.Writer = xe.ToString("Writer");
            episode.AbsoluteNumber = xe.ToString("absolute_number");
            episode.AirsAfterSeason = xe.ToString("airsafter_season");
            episode.AirsBeforeEpisode = xe.ToString("airsbefore_episode");
            episode.AirsBeforeSeason = xe.ToString("airsbefore_season");
            episode.Filename = xe.ToString("filename");
            episode.LastUpdated = xe.ToString("lastupdated");
            episode.SeasonID = xe.ToString("seasonid");
            episode.SeriesID = xe.ToString("seriesid");
            return episode;
        }

        #endregion
    }
}