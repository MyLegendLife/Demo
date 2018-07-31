using Demo.DAL;
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
    public class UserController : ApiController
    {
        public string Get()
        {
            //using (var context = new DemoContext())
            //{
            //    var users = context.Users;

            //    JavaScriptSerializer jsc = new JavaScriptSerializer();
            //    System.Text.StringBuilder jsonData = new System.Text.StringBuilder();
            //    jsc.Serialize(users, jsonData);

            //    return jsonData.ToString();
            //}

            string res = "";
            using (var context = new DemoContext())
            {
                var users = context.Users;
                
                foreach (var user in users)
                {
                    res += user.Id;
                }
            }

            return res;
        }
    }
}
