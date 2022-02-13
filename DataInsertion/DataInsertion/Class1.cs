using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataInsertion
{
    class Class1
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    }
}
