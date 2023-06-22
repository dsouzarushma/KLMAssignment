using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMAssignment.Common
{
    public class CSVHelper
    {
        string destTableName = ConfigurationManager.AppSettings["tableName"].ToString();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KLMConnectionString"].ToString());
        private async Task<bool> InsertCSVRecords(DataTable csvdt)
        {
            try
            {
                con.Open();
                SqlBulkCopy objbulk = new SqlBulkCopy(con);
                objbulk.DestinationTableName = destTableName;
                objbulk.ColumnMappings.Add("LegId", "LegId");
                objbulk.ColumnMappings.Add("AirlineCode", "AirlineCode");
                objbulk.ColumnMappings.Add("AircraftRegistration", "AircraftRegistration");
                objbulk.ColumnMappings.Add("FlightNumber", "FlightNumber");
                objbulk.ColumnMappings.Add("Suffix", "Suffix");
                objbulk.ColumnMappings.Add("DepartureStation", "DepartureStation");
                objbulk.ColumnMappings.Add("ArrivalStation", "ArrivalStation");
                objbulk.ColumnMappings.Add("STDDate", "STDDate");
                objbulk.ColumnMappings.Add("STDTime", "STDTime");
                objbulk.ColumnMappings.Add("ATDDate", "ATDDate");
                objbulk.ColumnMappings.Add("ATDTime", "ATDTime");
                objbulk.ColumnMappings.Add("STDDateLocal", "STDDateLocal");
                objbulk.ColumnMappings.Add("STDTimeLocal", "STDTimeLocal");
                objbulk.ColumnMappings.Add("ATDDateLocal", "ATDDateLocal");
                objbulk.ColumnMappings.Add("ATDTimeLocal", "ATDTimeLocal");
                objbulk.ColumnMappings.Add("STADate", "STADate");
                objbulk.ColumnMappings.Add("STATime", "STATime");
                objbulk.ColumnMappings.Add("ATADate", "ATADate");
                objbulk.ColumnMappings.Add("ATATime", "ATATime");
                objbulk.ColumnMappings.Add("STADateLocal", "STADateLocal");
                objbulk.ColumnMappings.Add("STATimeLocal", "STATimeLocal");
                objbulk.ColumnMappings.Add("ATADateLocal", "ATADateLocal");
                objbulk.ColumnMappings.Add("ATATimeLocal", "ATATimeLocal");
                objbulk.WriteToServer(csvdt);
                con.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> BulkCopy(string path)
        {
            DataTable tblcsv = new DataTable();
            tblcsv.Columns.Add("LegId");
            tblcsv.Columns.Add("AirlineCode");
            tblcsv.Columns.Add("AircraftRegistration");
            tblcsv.Columns.Add("FlightNumber");
            tblcsv.Columns.Add("Suffix");
            tblcsv.Columns.Add("DepartureStation");
            tblcsv.Columns.Add("ArrivalStation");
            tblcsv.Columns.Add("STDDate");
            tblcsv.Columns.Add("STDTime");
            tblcsv.Columns.Add("ATDDate");
            tblcsv.Columns.Add("ATDTime");
            tblcsv.Columns.Add("STDDateLocal");
            tblcsv.Columns.Add("STDTimeLocal");
            tblcsv.Columns.Add("ATDDateLocal");
            tblcsv.Columns.Add("ATDTimeLocal");
            tblcsv.Columns.Add("STADate");
            tblcsv.Columns.Add("STATime");
            tblcsv.Columns.Add("ATADate");
            tblcsv.Columns.Add("ATATime");
            tblcsv.Columns.Add("STADateLocal");
            tblcsv.Columns.Add("STATimeLocal");
            tblcsv.Columns.Add("ATADateLocal");
            tblcsv.Columns.Add("ATATimeLocal");

            string CSVFilePath = Path.GetFullPath(path);

            string ReadCSV = File.ReadAllText(CSVFilePath);

            foreach (string csvRow in ReadCSV.Split('\n'))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    tblcsv.Rows.Add();
                    int count = 0;
                    foreach (string FileRec in csvRow.Split(','))
                    {
                        tblcsv.Rows[tblcsv.Rows.Count - 1][count] = FileRec.Replace('"', ' ').Trim();
                        count++;
                    }
                }
            }
            bool result = await InsertCSVRecords(tblcsv);
            return result;
        }
    }
}
