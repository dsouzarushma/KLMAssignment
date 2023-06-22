using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Linq;
using KLMAssignment.Common;

namespace KLMAssignment.DAL
{
    public interface IDALBinding {
        public DataTable GetInboundOutboundData(string registrationCode, DateTime date);
    }
    public class DALBinding:IDALBinding
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KLMConnectionString"].ToString());
        public DataTable GetInboundOutboundData(string registrationCode,DateTime date)
        {
            DataTable dt = new DataTable();
            
            SqlCommand myCmd = new SqlCommand("sp_GetInboundOutboundData", con);
            con.Open();
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Clear();
            myCmd.Parameters.Add(new SqlParameter("@pRegistrationCode", registrationCode));
            myCmd.Parameters.Add(new SqlParameter("@pDate", date.Date));
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetInboundOutboundDataForFlights(string FlightNumber)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("sp_GetInboundOutboundDataFlight", con);
            con.Open();
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.Clear();
            myCmd.Parameters.Add(new SqlParameter("@pFlightNumber", FlightNumber));
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool LoadDataToMainTable()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("sp_InsertDataToMainTable", con);
                con.Open();
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.CommandTimeout = 60000;
                myCmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch { return false; }
        }

    }
}
