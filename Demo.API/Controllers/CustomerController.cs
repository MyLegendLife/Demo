using Demo.IBLL;
using Demo.Model;
using Demo.Model.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace Demo.API.Controllers
{
    [EnableCors("http://localhost","*","*")]
    public class CustomerController : ApiController
    {
        private ICustomerService customerService = BLLContainer.Container.Resolve<ICustomerService>();

        public string GetCustomers()
        {
            List<Customer> list = customerService.GetModels(p => true).ToList();

            return "123";
        }
    }
}
