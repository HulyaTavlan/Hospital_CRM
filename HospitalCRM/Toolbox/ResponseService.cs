using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public enum ResponseServiceCode
    {
        Success = 100,
        Information = 200,
        Warning = 300,
        Error = 400
    }
    public class ResponseService
    {
        public ResponseServiceCode Code { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }

    }
}
