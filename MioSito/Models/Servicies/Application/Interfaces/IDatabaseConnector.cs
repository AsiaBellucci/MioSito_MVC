using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application.Interfaces
{
    public interface IDatabaseConnector
    {
        //public DataSet QueryAsync(string query);
        //public void InsertQueryAsync(string insertquery, AddCourseViweModel corso);

        public  Task<DataSet> QueryAsync(string query);
        public  Task InsertQueryAsync(string insertquery, AddCourseViweModel corso);
    }
}
