using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Search;

namespace NicoNico.Net.Interfaces
{
    public interface ISearchManager
    {
        Task<Suggestion> GetSuggestions(string suggestion);
    }
}
