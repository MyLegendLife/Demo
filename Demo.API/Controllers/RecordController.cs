using Demo.IBLL;
using Demo.Infrastructure.ApiResult;
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
        private IRecordService recordService = BLLContainer.Container.Resolve<IRecordService>();

        public IHttpActionResult GetRecords()
        {
            Guid xddf = Guid.Parse("866cbb2c-4749-401c-86fa-9518ade6411e");

            var x = recordService.GetModels(a => a.Customer.Id == xddf).ToList();

            StandardResult res = new StandardResult(x, Request);

            int dd = x.Count();

           
            return res;
        }

        [HttpGet]
        public string Test()
        {
            var x = recordService.SelectRecords("大家庭");

            int ss= x.Count();

            return "123";
        }
    }
}
