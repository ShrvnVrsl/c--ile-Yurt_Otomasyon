using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp6
{

   public  class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KRI9USO;Initial Catalog=YurtKayıt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
