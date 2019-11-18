using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWithWebApi.Controllers
{
    //[RoutePrefix("api/sample")]
    public class SampleController : ApiController
    {
       // [HttpGet]
       // [Route("")]
        //get: /api/sample
        public string Get()
        {
            return DateTime.Now.ToString();
        }




        //[HttpGet]
       // [Route("{id}")]
        //get: /api/sample/1 (localhost:52836/api/sample/1)
        public string Get(int id)
        {
            return DateTime.Now.AddDays(id).ToString();
        }





        //Multiple actions were found that match the request with same arguments.. 
        //public string Get(string id)
        //{
        //    return "Hi " + id;
        //}





       // [HttpGet]
        //localhost:52836/api/sample/10?name=canarys so use routes bcos not in correct format
      //  [Route("{id}/{name}")]
        //localhost:52836/api/sample/10/canarys (after using routes)
        public string Get(string id, string name)
        {
            return "Hi " + name;
        }







        //[HttpPost]
       // [Route("")] // url= api/sample
        public string Post(int id, string name)     //use postman
        {
            var obj = new { Id = id, Name = name };
            JsonSerializer serializer = new JsonSerializer(); //convert obj to string
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);
            writer.Flush();
            var OutputString = writer.ToString();
            return OutputString;
        }
    }
}
