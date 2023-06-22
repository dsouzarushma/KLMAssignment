using System.Configuration;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using KLMAssignment.Common;
using KLMAssignment.DAL;
using KLMAssignment.Models;

namespace KLMAssignment
{
    public partial class Form1 : Form
    {
        CSVHelper csvHelper = new CSVHelper();
        DALBinding binding = new DALBinding();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text == "")
                {
                    MessageBox.Show("Please select the file");
                    return;
                }
                bool result = csvHelper.BulkCopy(txtFilePath.Text.ToString()).Result;
                if (result)
                {
                    bool finalResult = binding.LoadDataToMainTable();
                    if (finalResult)
                    {

                        DataTable dtResult = binding.GetInboundOutboundData("", Convert.ToDateTime(dateTimePicker1.Value));
                        ConfigureDataGrid(dtResult);

                        MessageBox.Show("Data loaded successfully");
                    }
                }
                else
                    MessageBox.Show("Data load Failed");
                txtFilePath.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Upload");
            }
        }

        public void ConfigureDataGrid(DataTable dtResult)
        {
            dGVInBound.AutoGenerateColumns = false;
            dGVOutBound.AutoGenerateColumns = false;
            dGVVisitTime.AutoGenerateColumns = false;
            dGVInBound.DataSource = null;
            dGVOutBound.DataSource = null;
            dGVVisitTime.DataSource = null;
            dGVInBound.DataSource = dtResult;
            dGVOutBound.DataSource = dtResult;
            dGVVisitTime.DataSource = dtResult;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select file to be upload.";
            openFileDialog1.Filter = "Select Valid Document(*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        txtFilePath.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegistrationCode.Text == "" && txtFlightNo.Text == "")
                {
                    MessageBox.Show("Either enter Registration Code and Date combination or Flight Number to search");
                    return;
                }
                if (txtRegistrationCode.Text != "" && txtFlightNo.Text != "")
                {
                    MessageBox.Show("Either one of Registration Code and Date combination or Flight Number can be used to search");
                    return;
                }
                DataTable dtResult = new DataTable();
                if (txtRegistrationCode.Text != "")
                {
                    dtResult = binding.GetInboundOutboundData(txtRegistrationCode.Text, Convert.ToDateTime(dateTimePicker1.Value));
                    if (dtResult.Rows.Count == 0)
                    {
                        MessageBox.Show("No records to Display");
                        return;
                    }
                    ConfigureDataGrid(dtResult);
                }
                if (txtFlightNo.Text != "")
                {
                    dtResult = binding.GetInboundOutboundDataForFlights(txtFlightNo.Text);
                    if (dtResult.Rows.Count == 0)
                    {
                        MessageBox.Show("No records to Display");
                        return;
                    }
                    var InBoundresults = from myRow in dtResult.AsEnumerable()
                                         where myRow.Field<string>("Flag").ToUpper().Equals("I")
                                         select myRow;
                    DataView viewIn = InBoundresults.AsDataView();
                    var OutBoundresults = from myRow in dtResult.AsEnumerable()
                                          where myRow.Field<string>("Flag").ToUpper().Equals("O")
                                          select myRow;
                    DataView viewOut = OutBoundresults.AsDataView();
                    dGVInBound.DataSource = viewIn;
                    dGVOutBound.DataSource = viewOut;
                    dGVVisitTime.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured in Search");
            }
        }
    }
}