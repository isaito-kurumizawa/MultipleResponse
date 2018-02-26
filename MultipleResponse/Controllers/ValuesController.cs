using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MultipleResponse.Controllers
{
    public class Hoge
    {
        public string Hoge1 { get; set; }
        public string Hoge2 { get; set; }

    }
    public class Hogeα : Hoge
    {
        public string Hogeα1 { get; set; }
        public string Hogeα2 { get; set; }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        public Hoge Get()
        {
            var model = new Hoge();
            model.Hoge1 = "hoge1";
            model.Hoge2 = "hoge2";
            return model;
        }

        // GET api/values/5
        public Hoge Get(int id)
        {
            var model = new Hogeα();
            model.Hoge1 = "hoge1";
            model.Hoge2 = "hoge2";
            model.Hogeα1 = "newhoge1";
            model.Hogeα2 = "newhoge2";
            return model;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
