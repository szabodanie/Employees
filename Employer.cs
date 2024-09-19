using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Employees
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public  int Salary { get; set; }
        public Employer(string row) 
        {
            string[] darabol = row.Split(';');
        }
    }

}
