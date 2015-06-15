using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Video;

namespace NicoNico.Net.Interfaces
{
    public interface IVideoManager
    {
        // TODO: Change "Genre", "Span", and "Type" to use enums
        Task<Videos> GetVideoRankingsAsync(int from, 
            string genre = "all", int limit = 20, string span = "hourly",
            string type = "fav");

        Task<Videos> GetDefListAsync(int from, int limit = 1);
    }
}
