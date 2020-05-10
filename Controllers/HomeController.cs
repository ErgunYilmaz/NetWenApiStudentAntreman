using NetWenApiStudentAntreman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWenApiStudentAntreman.Controllers
{
    public class HomeController : ApiController
    {
        StudentDBEntities db = new StudentDBEntities();
        public IEnumerable<Student> Get()
        {
            return db.Students.ToList();
        }
        public HttpResponseMessage Get(int id)
        {
            Student student = db.Students.FirstOrDefault(x => x.ID == id);
            if (student!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, student);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı bir öğrenci bulunamadı...");
            }
        }
        public HttpResponseMessage Put(int id)
    }
}
