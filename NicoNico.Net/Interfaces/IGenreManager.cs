using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Video;
using NicoNico.Net.Entities.VideoType;

namespace NicoNico.Net.Interfaces
{
    public interface IGenreManager
    {
        Task<List<Groups>> GetGenreGroupsAsync(int group = 1);

        Task<List<Genre>> GetGenreListAsync();
    }
}
