﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Video;
using NicoNico.Net.Entities.Web;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class GenreManager : IGenreManager
    {
        private readonly IWebManager _webManager;

        public GenreManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public GenreManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }


        public async Task<List<Groups>> GetGenreGroupsAsync(int @group = 1)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.GenreGroup, group)));
            var xmlUserObject = result.ResultXml.ParseXml<nicovideo_genre_response>();
            var groups = xmlUserObject.groups.Select(item => new Groups()
            {
                Group = item.@group, Keys = item.key.ToList(), Name = item.name
            }).ToList();

            return groups;
        }

        public async Task<List<Genre>> GetGenreListAsync()
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.GenreList)));
            var xmlUserObject = result.ResultXml.ParseXml<nicovideo_genre_response>();
            var genres = xmlUserObject.genre.Select(item => new Genre()
            {
                Key = item.key, Tag = item.tag
            }).ToList();
            return genres;
        }
    }
}
