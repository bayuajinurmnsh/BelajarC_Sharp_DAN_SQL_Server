using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Sesi_09_RestAPI.Models;

namespace Sesi_09_RestAPI.Controllers
{
    [Route("api/author")]
    [ApiController]
    public class AuthorContoller : ControllerBase
    {
        private EmployeeContext _context;
        public AuthorContoller(EmployeeContext context)
        {
            this._context = context;
        }

        // GET: api/User
        public ActionResult<IEnumerable<AuthorItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return _context.GetAllAuthor();
        }
    }
}
