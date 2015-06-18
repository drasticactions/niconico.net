using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.LiveVideo;

namespace NicoNico.Net.Interfaces
{
    public interface ILiveVideoManager
    {
        Task<NicoliveVideoResponse> GetOnAirListAsync(int from = 0, int length = 50, string order = "a",
            string provider = "community", string sort = "start_time");

        Task<NicoliveVideoResponse> GetComingSoonListAsync(int from = 0, int length = 50, string provider = "community");
    }
}
