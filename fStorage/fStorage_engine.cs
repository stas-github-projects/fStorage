using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace fStorage
{
    public partial class fStorage_engine
    {

        internal fStorage_globals _globals = new fStorage_globals();

        public fStorage_engine()
        {
            _globals.db_record_full_length = _globals.db_record_length + _globals.db_record_name_length;
        }

        public bool Open(string db_name, string db_options)
        {
            bool bool_ret = true;


            return bool_ret;
        }

    }

}
