using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Video;

namespace NicoNico.Net.Interfaces
{
    public interface IThumbManager
    {
        Task<Thumb> GetThumbInfoAsync(string videoId);
    }
}
