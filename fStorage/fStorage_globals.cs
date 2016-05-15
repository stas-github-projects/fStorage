using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fStorage
{
    internal class fStorage_globals
    {

        internal string db_filename = "";
        internal byte[] db_version = Encoding.ASCII.GetBytes("FST01");
        internal long db_created = 0;
        internal long db_last_modified = 0;

        internal int db_record_length = 42;
        internal int db_record_name_length = 8;
        internal int db_record_full_length = 0;

    }
}
