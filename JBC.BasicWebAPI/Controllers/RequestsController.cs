using System.Collections.Generic;
using System.Web.Http;

namespace JBC.BasicWebAPI
{
    [RoutePrefix("api/v1/requests")]
    public class RequestsController : ApiController
    {
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("")]
        public void Post([FromBody]string value)
        {
        }

    }
}