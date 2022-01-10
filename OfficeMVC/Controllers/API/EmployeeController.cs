using OfficeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OfficeMVC.Controllers.API
{
    public class EmployeeController : ApiController
    {
        //ברגע שמשהו מוציא ריקוואסט באוטומט זה יגיע לגט
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            List<Employee> listEmployee = new List<Employee>();
            return Ok(new { listEmployee });
        }

        // GET: api/Employee/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }
        //בשביל להגיע  לפוסט מוציאים בקשה עם מידע לבאדי במתודה פןסט
        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
