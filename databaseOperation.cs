using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace AdoConsoleDemos
{

    internal class databaseOperation
    {
        SqlConnection con;
        SqlCommand cmd;
        bool ans;
        int result;
        public databaseOperation()
        {
            con=new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=election;user id=sa;password=greysoft");
            cmd = new SqlCommand();
            ans = false;
            result = 0;
        }
        public bool CreateRecord(int id,int Pno,string PN,int Sr)
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into voters values(@p1,@p2,@P3,@P4)";
            cmd.Parameters.Add("@p1",SqlDbType.Int);
            cmd.Parameters.Add("@p2", SqlDbType.Int);
            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@p4", SqlDbType.Int);
            cmd.Parameters["@p1"].Value = id;
            cmd.Parameters["@p2"].Value= Pno;
            cmd.Parameters["@p3"].Value= PN;
            cmd.Parameters["@p4"].Value= Sr;  
            con.Open(); 
            int ans=cmd.ExecuteNonQuery();
            if (ans == 1)
            
                return true;
            else
                return false;


        }
        public bool CreateRecord(Voter v)
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into voters values(@p1,@p2,@P3,@P4)";
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters.Add("@p2", SqlDbType.Int);
            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@p4", SqlDbType.Int);
            cmd.Parameters["@p1"].Value = v.VoterId;
            cmd.Parameters["@p2"].Value = v.PartNo;
            cmd.Parameters["@p3"].Value = v.PartName;
            cmd.Parameters["@p4"].Value = v.serialNo;
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans == 1)

                return true;
            else
                return false;


        }
        public string ReadRecord()
        {
            cmd.Connection = con;
            cmd.CommandText = "select * from voters";
            string data = "";
            con.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            while(dr.Read())
            {
                data = data + "\nvoter id " + dr[0].ToString();
                data = data + "\npart number " + dr[1].ToString();
                data = data + "\npart name " + dr[2].ToString();
                data = data + "\nserial number " + dr[3].ToString();
            }
            
            return data;
           
        }
        public int UpdateRecord(string prevPartName,string newPartName)
        {
            cmd.Connection = con;
            cmd.CommandText="update voters set PartName=@p1 where PartName=@p2";
            con.Open();
            cmd.Parameters.Add("@p1",SqlDbType.VarChar,20);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 20);
            cmd.Parameters["@p1"].Value = newPartName;
            cmd.Parameters["@p2"].Value = prevPartName;
            int ans= cmd.ExecuteNonQuery();
            return ans;


        }
        public int UpdateRecord(ChangeInfo c)
        {
            cmd.Connection = con;
            cmd.CommandText = "update voters set PartName=@p1 where PartName=@p2";
            con.Open();
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 20);
            cmd.Parameters["@p1"].Value = c.newPartName;
            cmd.Parameters["@p2"].Value = c.prevPartName;
            int ans = cmd.ExecuteNonQuery();
            return ans;


        }
        public int deleteRecord(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from voters where VoterId=@p1";
            con.Open();
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters["@p1"].Value=id;
            int ans= cmd.ExecuteNonQuery();
            return ans;
        }
    }
}
