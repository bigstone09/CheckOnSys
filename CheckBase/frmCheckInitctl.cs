using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsharpSQLite;

namespace CheckBase
{
    public class frmCheckInitctl
    {
        static string sql_insert_record = @"insert into check_record(record_id,start_time,info,create_time) values('{0}','{1}','{2}','{3}','{4}')";


        public static bool insert_record(string id, string time_s, string info,string create_time)
        {
            bool bR = false;
            try
            {
                int result = 0;
                object[] pars = new object[]
	                    {
                            id,time_s,info,create_time
	                    };

                result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(sql_insert_record, pars).ToString());
                if (result >= 1)
                {
                    bR = true;
                }
                else
                {
                    bR = false;
                }

            }
            catch (System.Exception ex)
            {
                //MessageBox.Show("出现错误：" + ex.Message);
            }
            return bR;
        }
    }
}
