using Demo.DAL;
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
    public class UserController : ApiController
    {
        public JArray GetUsers()
        {
            //using (var context = new DemoContext())
            //{
            //    var users = context.Users;

            //    JavaScriptSerializer jsc = new JavaScriptSerializer();
            //    System.Text.StringBuilder jsonData = new System.Text.StringBuilder();
            //    jsc.Serialize(users, jsonData);

            //    return jsonData.ToString();
            //} 

            using (var context = new DemoContext())
            {
                var users = context.Users;

                //string json = JsonConvert.SerializeObject(users);

                string json = ToJsonString(users);

                var res = JArray.Parse(json);
                
                return res;
            }
        }

        public JArray GetStudents()
        {
            string str = "[{'key':'1','name':'john','age':32,'address':'china1'},{'key':'2','name':'john','age':32,'address':'china2'},{'key':'3','name':'john','age':32,'address':'china'}]";

            var res = JArray.Parse(str);

            return res;
        }

        public string ToJsonString(Object obj)
        {
            JsonSerializerSettings jsSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(obj, jsSettings);
        }
    }
}
