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
using System.Web.Http.Results;
using System.Web.Script.Serialization;

namespace Demo.API.Controllers
{
    [EnableCors("http://localhost","*","*")]
    public class CustomerController : ApiController
    {
        private ICustomerService customerService = BLLContainer.Container.Resolve<ICustomerService>();

        public string GetCustomers()
        {
            //Customer customer = new Customer()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "大家庭",
            //    Tel = "13555555555",
            //    Level = 5
            //};

            //customerService.Add(customer);

            List<Customer> list = customerService.GetModels(p => true).ToList();

            Customer xx = customerService.Get(Guid.Parse("866CBB2C-4749-401C-86FA-9518ADE6411E"));

            int x = customerService.GetLevel(Guid.Parse("866CBB2C-4749-401C-86FA-9518ADE64113"));

            return x.ToString();
        }

        [HttpGet]
        public string Test(string id)
        {

            //string id = httpquer

            var ss = customerService.GetAsync(Guid.Parse("866CBB2C-4749-401C-86FA-9518ADE64113"));

            string x = ""; 

            string y = x + "22";

            return id;
        }
    }
}
