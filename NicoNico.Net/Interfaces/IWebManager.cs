using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Web;

namespace NicoNico.Net.Interfaces
{
    public interface IWebManager
    {
        bool IsNetworkAvailable { get; }
        bool IsSessionKeySet { get; }
        bool IsCookieContainerSet { get; }
        Task<Result> PostData(Uri uri, MultipartContent header, StringContent content);

        Task<Result> PutData(Uri uri, StringContent json);

        Task<Result> DeleteData(Uri uri, StringContent json);

        Task<Result> GetData(Uri uri);
    }
}
