using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CaApp.Data;

namespace CaApp
{
    public partial class ExportConDataController : ExportController
    {
        private readonly ConDataContext context;

        public ExportConDataController(ConDataContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/ConData/countries/csv")]
        [HttpGet("/export/ConData/countries/csv(fileName='{fileName}')")]
        public FileStreamResult ExportCountriesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Countries, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/countries/excel")]
        [HttpGet("/export/ConData/countries/excel(fileName='{fileName}')")]
        public FileStreamResult ExportCountriesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Countries, Request.Query), fileName);
        }
    }
}
