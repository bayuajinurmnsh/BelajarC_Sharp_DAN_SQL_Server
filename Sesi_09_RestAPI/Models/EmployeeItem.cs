using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi_09_RestAPI.Models
{
    public class EmployeeItem
    {
        private Models.EmployeeContext context;

        public int id { get; set; }
        public string nama { get; set; }
        public string jenisKelamin { get; set; }
        public string alamat { get; set; }
    }

    public class AuthorItem
    {
        private Models.EmployeeContext context;
        public int id { get; set; }
        public string author_name { get; set; }
    }
}