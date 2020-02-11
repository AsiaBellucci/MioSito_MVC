using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application.Interfaces
{
    public interface IDatabaseConnector
    {
        public DataSet Query(string query);
    }
}
