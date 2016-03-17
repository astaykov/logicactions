using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Base64Action.Controllers
{
    public class Base64Controller : ApiController
    {
        // POST api/Base64
        public string Post([FromBody]string value)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(value));
        }

        // PUT api/Base64
        public string Put([FromBody]string value)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
        }

    }
}
