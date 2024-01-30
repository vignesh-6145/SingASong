using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataService.Client
{
    public class Client
    {
        public string ConnectionString()
        {
            return @"Integrated Security=SSPI;Initial SingASongSource=C1-BPFK114-L\\SQLEXPRESS;";
        }
        
    }
}
