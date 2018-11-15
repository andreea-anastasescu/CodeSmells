using System;
using static CodeSmells.Bloaters.LongClass.MultipleResponsabilities.GodObject.EmployeeUtils;

namespace CodeSmells.Bloaters.LongClass.MultipleResponsabilities.GodObject
{
    class ProposedSolution
    {

        public interface IImportExport
        {
            void ExportEmpDetailsToCSV(EmployeeModel employeDetails);
            void ImportEmpDetailsForDb(EmployeeModel employeeDetails); 
        }

        public class ImportExport : IImportExport
        {
            public void ExportEmpDetailsToCSV(EmployeeModel employeDetails)
            {
                throw new NotImplementedException();
            }

            public void ImportEmpDetailsForDb(EmployeeModel employeeDetails)
            {
                throw new NotImplementedException();
            }
        }

               
        public interface IEmployeeDbOperations
        {
            void FetchEmployeeDetails(string employeeId);
            void SaveEmployeeDetails(EmployeeModel employeeDetails);
        }

        public class EmployeeDbOperations : IEmployeeDbOperations
        {
            public void FetchEmployeeDetails(string employeeId)
            {
                throw new NotImplementedException();
            }

            public void SaveEmployeeDetails(EmployeeModel employeeDetails)
            {
                throw new NotImplementedException();
            }
        }
    }
}
