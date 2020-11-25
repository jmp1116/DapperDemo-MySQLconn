using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_Demo
{
    interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
