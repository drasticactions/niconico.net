using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.Web
{
    public class Result
    {
        public Result(bool isSuccess, string xml)
        {
            IsSuccess = isSuccess;
            ResultXml = xml;
        }

        public bool IsSuccess { get; private set; }
        public string ResultXml { get; private set; }
    }
}
