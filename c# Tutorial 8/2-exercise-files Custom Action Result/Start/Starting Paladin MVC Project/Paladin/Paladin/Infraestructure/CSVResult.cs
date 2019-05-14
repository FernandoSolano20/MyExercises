using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paladin.Infraestructure
{
    //fileResult Hereda de actionresult por ello no hay que preocuparse de heredar de actionresult
    public class CSVResult : FileResult
    {
        private IEnumerable _data;
        public CSVResult(IEnumerable data, string fileName) : base("text/csv")
        {
            _data = data;
            FileDownloadName = fileName;
        }

        protected override void WriteFile(HttpResponseBase response)
        {
            
        }
    }
}