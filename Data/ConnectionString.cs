using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Data
{
    public class ConnectionString
    {
        private static string DCS = "Data Source=.\\SQLEXPRESS;Database=DbIR;Integrated Security=true";
        public static string _DCS { get => DCS; }
    }
}
