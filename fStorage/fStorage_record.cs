using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fStorage
{
    internal class fStorage_record
    {
        internal fStorage_record(int _record_length)
        { this.record_length = _record_length; }

        int record_length = 0;
        //visibility = 0|1 //reserved
        byte record_level;
        byte record_data_type;
        byte record_is_unix_time;
        long record_created;
        ulong record_parent_id;
        ulong record_current_id;
        ushort record_fixed_length;
        int record_data_length;
        long record_data_pos;
        string record_name;

        internal byte[] getBytes()
        {
            int ipos = 0;
            byte[] b_out = new byte[record_length];
            b_out[0] = 1; ipos++;//visibility
            b_out[1] = record_level; ipos++;//level
            b_out[2] = record_data_type; ipos++;//data_type
            b_out[3] = record_is_unix_time; ipos++;//is_unix
            b_out.InsertBytes(BitConverter.GetBytes(record_fixed_length)); ipos += 2;//fixed_length
            b_out.InsertBytes(BitConverter.GetBytes(record_parent_id)); ipos += 8;//parent_id
            b_out.InsertBytes(BitConverter.GetBytes(record_current_id)); ipos += 8;//current_id
            b_out.InsertBytes(BitConverter.GetBytes(record_created)); ipos += 8;//created
            b_out.InsertBytes(BitConverter.GetBytes(record_data_pos)); ipos += 8;//data_pos
            b_out.InsertBytes(BitConverter.GetBytes(record_data_length)); ipos += 4;//data_len
            b_out.InsertBytes(Encoding.ASCII.GetBytes(record_name));//record_name

            return b_out;
        }
    }

}
