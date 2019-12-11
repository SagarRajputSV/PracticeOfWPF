using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BALClass
    {
        public List <ListBindingClass> BALDataGrid()
        {
            List<ListBindingClass> names = new List<ListBindingClass>();

            ListBindingClass name1 = new ListBindingClass();
            ListBindingClass name2 = new ListBindingClass();
            ListBindingClass name3 = new ListBindingClass();

            name1.Id = 100;
            name1.Name = "abc";
            name1.age = 23;
            name1.CompanyWorking = "Cognizant Softvision";

            name2.Id = 101;
            name2.Name = "pqr";
            name2.age = 23;
            name2.CompanyWorking = "Cognizant Softvision";

            name3.Id = 102;
            name3.Name = "xyz";
            name3.age = 23;
            name3.CompanyWorking = "Cognizant Softvision";

            names.Add(name1);
            names.Add(name2);
            names.Add(name3);

            return names;
        }
    }
}
