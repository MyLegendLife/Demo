using Demo.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.API.Controllers
{
    public class RecordController : ApiController
    {
        private IRecordService RecordService = BLLContainer.Container.Resolve<IRecordService>();

        public string GetRecords()
        {
            Guid xddf = Guid.Parse("866cbb2c-4749-401c-86fa-9518ade6411e");

            var x = RecordService.GetModels(a => a.Customer.Id == xddf);



            int dd = x.Count();

            return dd.ToString();
        }
    }
}
