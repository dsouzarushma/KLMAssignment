namespace KLMAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dGVInBound = new DataGridView();
            arrivalLeg = new DataGridViewTextBoxColumn();
            AircraftRegistration = new DataGridViewTextBoxColumn();
            InboundFlight = new DataGridViewTextBoxColumn();
            InboundDeparture = new DataGridViewTextBoxColumn();
            InboundArrival = new DataGridViewTextBoxColumn();
            InboundDeparturedate = new DataGridViewTextBoxColumn();
            InboundDeparturetime = new DataGridViewTextBoxColumn();
            InboundArrivalDate = new DataGridViewTextBoxColumn();
            InboundArrivaltime = new DataGridViewTextBoxColumn();
            btnBrowse = new Button();
            btnUpload = new Button();
            txtFilePath = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            gBInBound = new GroupBox();
            gBOutbound = new GroupBox();
            dGVOutBound = new DataGridView();
            departureleg = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            OutbounFlight = new DataGridViewTextBoxColumn();
            OutboundDeparture = new DataGridViewTextBoxColumn();
            OutboundArrival = new DataGridViewTextBoxColumn();
            OutboundDeparturedate = new DataGridViewTextBoxColumn();
            OutboundDeparturetime = new DataGridViewTextBoxColumn();
            outboundArrivalDate = new DataGridViewTextBoxColumn();
            outboundArrivaltime = new DataGridViewTextBoxColumn();
            gBFileUpload = new GroupBox();
            gBFilters = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txtFlightNo = new TextBox();
            lblFlightNo = new Label();
            lblDate = new Label();
            txtRegistrationCode = new TextBox();
            lblRegistrationCode = new Label();
            btnSearch = new Button();
            dGVVisitTime = new DataGridView();
            VisitTime = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGVInBound).BeginInit();
            gBInBound.SuspendLayout();
            gBOutbound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVOutBound).BeginInit();
            gBFileUpload.SuspendLayout();
            gBFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVVisitTime).BeginInit();
            SuspendLayout();
            // 
            // dGVInBound
            // 
            dGVInBound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVInBound.Columns.AddRange(new DataGridViewColumn[] { arrivalLeg, AircraftRegistration, InboundFlight, InboundDeparture, InboundArrival, InboundDeparturedate, InboundDeparturetime, InboundArrivalDate, InboundArrivaltime });
            dGVInBound.Location = new Point(18, 49);
            dGVInBound.Name = "dGVInBound";
            dGVInBound.RowHeadersWidth = 51;
            dGVInBound.RowTemplate.Height = 29;
            dGVInBound.Size = new Size(681, 381);
            dGVInBound.TabIndex = 0;
            // 
            // arrivalLeg
            // 
            arrivalLeg.DataPropertyName = "arrivalLeg";
            arrivalLeg.HeaderText = "Leg ID";
            arrivalLeg.MinimumWidth = 6;
            arrivalLeg.Name = "arrivalLeg";
            arrivalLeg.Width = 125;
            // 
            // AircraftRegistration
            // 
            AircraftRegistration.DataPropertyName = "AircraftRegistration";
            AircraftRegistration.HeaderText = "Aircraft Registration Code";
            AircraftRegistration.MinimumWidth = 6;
            AircraftRegistration.Name = "AircraftRegistration";
            AircraftRegistration.Width = 125;
            // 
            // InboundFlight
            // 
            InboundFlight.DataPropertyName = "InboundFlight";
            InboundFlight.HeaderText = "Flight Number";
            InboundFlight.MinimumWidth = 6;
            InboundFlight.Name = "InboundFlight";
            InboundFlight.Width = 125;
            // 
            // InboundDeparture
            // 
            InboundDeparture.DataPropertyName = "InboundDeparture";
            InboundDeparture.HeaderText = "Departure Station";
            InboundDeparture.MinimumWidth = 6;
            InboundDeparture.Name = "InboundDeparture";
            InboundDeparture.Width = 125;
            // 
            // InboundArrival
            // 
            InboundArrival.DataPropertyName = "InboundArrival";
            InboundArrival.HeaderText = "Arrival Station";
            InboundArrival.MinimumWidth = 6;
            InboundArrival.Name = "InboundArrival";
            InboundArrival.Width = 125;
            // 
            // InboundDeparturedate
            // 
            InboundDeparturedate.DataPropertyName = "InboundDeparturedate";
            InboundDeparturedate.HeaderText = "Departure Date";
            InboundDeparturedate.MinimumWidth = 6;
            InboundDeparturedate.Name = "InboundDeparturedate";
            InboundDeparturedate.Width = 125;
            // 
            // InboundDeparturetime
            // 
            InboundDeparturetime.DataPropertyName = "InboundDeparturetime";
            InboundDeparturetime.HeaderText = "Departure Time";
            InboundDeparturetime.MinimumWidth = 6;
            InboundDeparturetime.Name = "InboundDeparturetime";
            InboundDeparturetime.Width = 125;
            // 
            // InboundArrivalDate
            // 
            InboundArrivalDate.DataPropertyName = "InboundArrivalDate";
            InboundArrivalDate.HeaderText = "Arrival Date";
            InboundArrivalDate.MinimumWidth = 6;
            InboundArrivalDate.Name = "InboundArrivalDate";
            InboundArrivalDate.Width = 125;
            // 
            // InboundArrivaltime
            // 
            InboundArrivaltime.DataPropertyName = "InboundArrivaltime";
            InboundArrivaltime.HeaderText = "Arrival Time";
            InboundArrivaltime.MinimumWidth = 6;
            InboundArrivaltime.Name = "InboundArrivaltime";
            InboundArrivaltime.Width = 125;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(512, 26);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(639, 26);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(25, 26);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(469, 27);
            txtFilePath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Select File";
            // 
            // gBInBound
            // 
            gBInBound.Controls.Add(dGVInBound);
            gBInBound.Location = new Point(37, 321);
            gBInBound.Name = "gBInBound";
            gBInBound.Size = new Size(719, 459);
            gBInBound.TabIndex = 3;
            gBInBound.TabStop = false;
            gBInBound.Text = "InBound Flights";
            // 
            // gBOutbound
            // 
            gBOutbound.Controls.Add(dGVOutBound);
            gBOutbound.Location = new Point(1079, 332);
            gBOutbound.Name = "gBOutbound";
            gBOutbound.Size = new Size(768, 487);
            gBOutbound.TabIndex = 4;
            gBOutbound.TabStop = false;
            gBOutbound.Text = "OutBound Flights";
            // 
            // dGVOutBound
            // 
            dGVOutBound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVOutBound.Columns.AddRange(new DataGridViewColumn[] { departureleg, dataGridViewTextBoxColumn1, OutbounFlight, OutboundDeparture, OutboundArrival, OutboundDeparturedate, OutboundDeparturetime, outboundArrivalDate, outboundArrivaltime });
            dGVOutBound.Location = new Point(25, 47);
            dGVOutBound.Name = "dGVOutBound";
            dGVOutBound.RowHeadersWidth = 51;
            dGVOutBound.RowTemplate.Height = 29;
            dGVOutBound.Size = new Size(711, 372);
            dGVOutBound.TabIndex = 0;
            // 
            // departureleg
            // 
            departureleg.DataPropertyName = "departureleg";
            departureleg.HeaderText = "Leg ID";
            departureleg.MinimumWidth = 6;
            departureleg.Name = "departureleg";
            departureleg.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "AircraftRegistration";
            dataGridViewTextBoxColumn1.HeaderText = "Aircraft Registration Code";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // OutbounFlight
            // 
            OutbounFlight.DataPropertyName = "OutbounFlight";
            OutbounFlight.HeaderText = "Flight Number";
            OutbounFlight.MinimumWidth = 6;
            OutbounFlight.Name = "OutbounFlight";
            OutbounFlight.Width = 125;
            // 
            // OutboundDeparture
            // 
            OutboundDeparture.DataPropertyName = "OutboundDeparture";
            OutboundDeparture.HeaderText = "Departure Station";
            OutboundDeparture.MinimumWidth = 6;
            OutboundDeparture.Name = "OutboundDeparture";
            OutboundDeparture.Width = 125;
            // 
            // OutboundArrival
            // 
            OutboundArrival.DataPropertyName = "OutboundArrival";
            OutboundArrival.HeaderText = "Arrival Station";
            OutboundArrival.MinimumWidth = 6;
            OutboundArrival.Name = "OutboundArrival";
            OutboundArrival.Width = 125;
            // 
            // OutboundDeparturedate
            // 
            OutboundDeparturedate.DataPropertyName = "OutboundDeparturedate";
            OutboundDeparturedate.HeaderText = "Departure Date";
            OutboundDeparturedate.MinimumWidth = 6;
            OutboundDeparturedate.Name = "OutboundDeparturedate";
            OutboundDeparturedate.Width = 125;
            // 
            // OutboundDeparturetime
            // 
            OutboundDeparturetime.DataPropertyName = "OutboundDeparturetime";
            OutboundDeparturetime.HeaderText = "Departure Time";
            OutboundDeparturetime.MinimumWidth = 6;
            OutboundDeparturetime.Name = "OutboundDeparturetime";
            OutboundDeparturetime.Width = 125;
            // 
            // outboundArrivalDate
            // 
            outboundArrivalDate.DataPropertyName = "outboundArrivalDate";
            outboundArrivalDate.HeaderText = "Arrival Date";
            outboundArrivalDate.MinimumWidth = 6;
            outboundArrivalDate.Name = "outboundArrivalDate";
            outboundArrivalDate.Width = 125;
            // 
            // outboundArrivaltime
            // 
            outboundArrivaltime.DataPropertyName = "outboundArrivaltime";
            outboundArrivaltime.HeaderText = "Arrival Time";
            outboundArrivaltime.MinimumWidth = 6;
            outboundArrivaltime.Name = "outboundArrivaltime";
            outboundArrivaltime.Width = 125;
            // 
            // gBFileUpload
            // 
            gBFileUpload.Controls.Add(txtFilePath);
            gBFileUpload.Controls.Add(btnBrowse);
            gBFileUpload.Controls.Add(btnUpload);
            gBFileUpload.Location = new Point(12, 12);
            gBFileUpload.Name = "gBFileUpload";
            gBFileUpload.Size = new Size(762, 76);
            gBFileUpload.TabIndex = 5;
            gBFileUpload.TabStop = false;
            gBFileUpload.Text = "File Upload";
            // 
            // gBFilters
            // 
            gBFilters.Controls.Add(dateTimePicker1);
            gBFilters.Controls.Add(txtFlightNo);
            gBFilters.Controls.Add(lblFlightNo);
            gBFilters.Controls.Add(lblDate);
            gBFilters.Controls.Add(txtRegistrationCode);
            gBFilters.Controls.Add(lblRegistrationCode);
            gBFilters.Controls.Add(btnSearch);
            gBFilters.Location = new Point(12, 124);
            gBFilters.Name = "gBFilters";
            gBFilters.Size = new Size(1274, 91);
            gBFilters.TabIndex = 6;
            gBFilters.TabStop = false;
            gBFilters.Text = "Filters";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(474, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtFlightNo
            // 
            txtFlightNo.Location = new Point(898, 32);
            txtFlightNo.Name = "txtFlightNo";
            txtFlightNo.Size = new Size(221, 27);
            txtFlightNo.TabIndex = 6;
            // 
            // lblFlightNo
            // 
            lblFlightNo.AutoSize = true;
            lblFlightNo.Location = new Point(756, 39);
            lblFlightNo.Name = "lblFlightNo";
            lblFlightNo.Size = new Size(104, 20);
            lblFlightNo.TabIndex = 5;
            lblFlightNo.Text = "Flight Number";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(392, 39);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            // 
            // txtRegistrationCode
            // 
            txtRegistrationCode.Location = new Point(150, 31);
            txtRegistrationCode.Name = "txtRegistrationCode";
            txtRegistrationCode.Size = new Size(213, 27);
            txtRegistrationCode.TabIndex = 2;
            // 
            // lblRegistrationCode
            // 
            lblRegistrationCode.AutoSize = true;
            lblRegistrationCode.Location = new Point(20, 34);
            lblRegistrationCode.Name = "lblRegistrationCode";
            lblRegistrationCode.Size = new Size(124, 20);
            lblRegistrationCode.TabIndex = 1;
            lblRegistrationCode.Text = "RegistrationCode";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1165, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dGVVisitTime
            // 
            dGVVisitTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVVisitTime.Columns.AddRange(new DataGridViewColumn[] { VisitTime, dataGridViewTextBoxColumn2 });
            dGVVisitTime.Location = new Point(789, 370);
            dGVVisitTime.Name = "dGVVisitTime";
            dGVVisitTime.RowHeadersWidth = 51;
            dGVVisitTime.RowTemplate.Height = 29;
            dGVVisitTime.Size = new Size(252, 381);
            dGVVisitTime.TabIndex = 7;
            // 
            // VisitTime
            // 
            VisitTime.DataPropertyName = "VisitTime";
            VisitTime.HeaderText = "Visit Time In Minutes";
            VisitTime.MinimumWidth = 6;
            VisitTime.Name = "VisitTime";
            VisitTime.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "arrivalLeg";
            dataGridViewTextBoxColumn2.HeaderText = "Leg ID";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 858);
            Controls.Add(dGVVisitTime);
            Controls.Add(gBFilters);
            Controls.Add(gBFileUpload);
            Controls.Add(gBOutbound);
            Controls.Add(gBInBound);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dGVInBound).EndInit();
            gBInBound.ResumeLayout(false);
            gBOutbound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVOutBound).EndInit();
            gBFileUpload.ResumeLayout(false);
            gBFileUpload.PerformLayout();
            gBFilters.ResumeLayout(false);
            gBFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVVisitTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBrowse;
        private Button btnUpload;
        private TextBox txtFilePath;
        private OpenFileDialog openFileDialog1;
        private GroupBox gBInBound;
        private DataGridView dGVInBound;
        private GroupBox gBOutbound;
        private DataGridView dGVOutBound;
        private GroupBox gBFileUpload;
        private GroupBox gBFilters;
        private TextBox txtFlightNo;
        private Label lblFlightNo;
        private Label lblDate;
        private TextBox txtRegistrationCode;
        private Label lblRegistrationCode;
        private Button btnSearch;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn departureleg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn OutbounFlight;
        private DataGridViewTextBoxColumn OutboundDeparture;
        private DataGridViewTextBoxColumn OutboundArrival;
        private DataGridViewTextBoxColumn OutboundDeparturedate;
        private DataGridViewTextBoxColumn OutboundDeparturetime;
        private DataGridViewTextBoxColumn outboundArrivalDate;
        private DataGridViewTextBoxColumn outboundArrivaltime;
        private DataGridView dGVVisitTime;
        private DataGridViewTextBoxColumn VisitTime;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn arrivalLeg;
        private DataGridViewTextBoxColumn AircraftRegistration;
        private DataGridViewTextBoxColumn InboundFlight;
        private DataGridViewTextBoxColumn InboundDeparture;
        private DataGridViewTextBoxColumn InboundArrival;
        private DataGridViewTextBoxColumn InboundDeparturedate;
        private DataGridViewTextBoxColumn InboundDeparturetime;
        private DataGridViewTextBoxColumn InboundArrivalDate;
        private DataGridViewTextBoxColumn InboundArrivaltime;
    }
}