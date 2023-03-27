using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAppLayer.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        [Route("api/employee")]
        public HttpResponseMessage AllEmployee()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
              return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message); 
            } 
            
        }
    }
}
