using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
//using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWithWebApi.Controllers
{
    public class Sample2Controller : ApiController
    {


        //when u want to send response to the user

        //public HttpResponseMessage Get(int id)   //gives extra info and have better crl to giv client
        //{
        //    //create response stream
        //    var response = Request.CreateResponse();
        //    //add conntent to the response stream, content can be string or obj
        //    response.Content = new StringContent(
        //        content: "the input was " + id.ToString() + "and response was sent");
        //    if (id > 10)
        //        response.StatusCode = HttpStatusCode.OK;
        //    else
        //        response.StatusCode = HttpStatusCode.BadRequest;
        //    response.ReasonPhrase = "the request is processed";
        //    return response;
        //}



        //public IHttpActionResult Get(int id)
        //{

        //    if (id > 10)
        //        return Ok("the input was " + id.ToString() + "and the response was sent");
        //    else
        //        return BadRequest("some data is missing");
        //}




        [HttpGet]
        //[ActionName("check")]
        [Route("api/sample2")]
        //other than get-mtd need not be get always. Based on route, relevent mtds r given
        //public IHttpActionResult CheckInputAndReturnString(/*int id*/)
        //{
        //    var id = 10;
        //    if (id > 10)
        //        return Ok("the input was " + id.ToString() + "and the response was sent");
        //    else
        //        return BadRequest("some data is missing");
        //}


        public IHttpActionResult CheckInputAndReturnString(/*int id*/)
        {
            WebClient client = new WebClient();
            var countries = client.DownloadString("https://restcountries.eu/rest/v2/region/asia");
            var reader = new JsonTextReader(new StringReader(countries));
            JsonSerializer serializer = new JsonSerializer();
            object obj = serializer.Deserialize(reader);
            return Ok(obj);
           
        }
    }
}
