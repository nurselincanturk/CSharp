using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _16253013projeYemekSepeti
{
    class Class1
    {
        SqlConnection connection;
        SqlCommand komut;
        SqlDataAdapter sqa;
        string a;

        public Class1(string b)
        {
            a = b;

        }
        public DataTable SelectTablo(string cmdStr)
        {


            connection = new SqlConnection(a);
            komut = new SqlCommand(cmdStr, connection);
            sqa = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                sqa.Fill(dt);


            }

            catch
            {



            }

            finally
            {
                connection.Close();

            }

            return dt;

        }

        public int RunCommand(string cmdStr)
        {
            int satirSayisi = 0;

            connection = new SqlConnection(a);
            komut = new SqlCommand(cmdStr, connection);


            try
            {
                connection.Open();
                satirSayisi = komut.ExecuteNonQuery();



            }
            catch
            {
                satirSayisi = -1;

            }
            finally
            {
                connection.Close();
            }
            return satirSayisi;

        }

        public SqlDataReader KomutReader(string cmdStr)
        {

            connection = new SqlConnection(a);
            komut = new SqlCommand(cmdStr, connection);
            SqlDataReader sqlD = null;
            try
            {
                connection.Open();
                sqlD = komut.ExecuteReader();



            }

            catch
            {

                sqlD = null;

            }
            finally
            {
               
            }

            return sqlD;

        }
        public void close() 
        {

            connection.Close();
        }


    }
}
