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
        public int Age { get; set; }
        public  int Salary { get; set; }
    

        public Employer(string row) 
        {
            string[] darabol = row.Split(';');
            Id = int.Parse(darabol[0]);
            Name = darabol[1];
            Age = int.Parse(darabol[2]);
            Salary = int.Parse(darabol[3]);

        }
    }

}
