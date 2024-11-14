using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Laboratorio19_1.Models.WS;
using System.Web.Http;

namespace Laboratorio19_1.Controllers
{
    public class AccessController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }


        public void Delete(int id)
        {
        }

        [HttpGet]
        public Reply HelloWord()
        {
            Reply Or = new Reply();
            Or.result = 1;
            Or.message = "Mi Hello Word en API";
            Or.data = new object();
            return Or;
        }

    }
}