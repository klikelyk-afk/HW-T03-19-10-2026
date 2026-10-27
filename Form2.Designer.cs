namespace WinFormsApp_DNS_511
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGetIpInfo = new Button();
            textBoxOutput = new TextBox();
            buttonGetLastIp = new Button();
            listBoxAddresses = new ListBox();
            buttonGetBankInfo = new Button();
            listBoxRates = new ListBox();
            listBoxUniversities = new ListBox();
            buttonCheckUniversities = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            lblDistance = new Label();
            textBoxHost1 = new TextBox();
            textBoxHost2 = new TextBox();
            lblLat1 = new Label();
            lblLon1 = new Label();
            lblLat2 = new Label();
            lblLon2 = new Label();
            SuspendLayout();
            // 
            // buttonGetIpInfo
            // 
            buttonGetIpInfo.Location = new Point(10, 11);
            buttonGetIpInfo.Margin = new Padding(3, 2, 3, 2);
            buttonGetIpInfo.Name = "buttonGetIpInfo";
            buttonGetIpInfo.Size = new Size(71, 22);
            buttonGetIpInfo.TabIndex = 0;
            buttonGetIpInfo.Text = "Get IP info";
            buttonGetIpInfo.UseVisualStyleBackColor = true;
            buttonGetIpInfo.Click += buttonGetIpInfo_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(10, 238);
            textBoxOutput.Margin = new Padding(3, 2, 3, 2);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(877, 92);
            textBoxOutput.TabIndex = 1;
            // 
            // buttonGetLastIp
            // 
            buttonGetLastIp.Location = new Point(87, 11);
            buttonGetLastIp.Margin = new Padding(3, 2, 3, 2);
            buttonGetLastIp.Name = "buttonGetLastIp";
            buttonGetLastIp.Size = new Size(75, 22);
            buttonGetLastIp.TabIndex = 2;
            buttonGetLastIp.Text = "Get last Ip";
            buttonGetLastIp.UseVisualStyleBackColor = true;
            buttonGetLastIp.Click += buttonGetLastIp_Click;
            // 
            // listBoxAddresses
            // 
            listBoxAddresses.FormattingEnabled = true;
            listBoxAddresses.Location = new Point(12, 50);
            listBoxAddresses.Margin = new Padding(3, 2, 3, 2);
            listBoxAddresses.Name = "listBoxAddresses";
            listBoxAddresses.Size = new Size(132, 184);
            listBoxAddresses.TabIndex = 3;
            listBoxAddresses.SelectedIndexChanged += listBoxAddresses_SelectedIndexChanged;
            // 
            // buttonGetBankInfo
            // 
            buttonGetBankInfo.Location = new Point(633, 9);
            buttonGetBankInfo.Margin = new Padding(3, 2, 3, 2);
            buttonGetBankInfo.Name = "buttonGetBankInfo";
            buttonGetBankInfo.Size = new Size(209, 22);
            buttonGetBankInfo.TabIndex = 4;
            buttonGetBankInfo.Text = "Get bank info";
            buttonGetBankInfo.UseVisualStyleBackColor = true;
            buttonGetBankInfo.Click += buttonGetBankInfo_Click;
            // 
            // listBoxRates
            // 
            listBoxRates.FormattingEnabled = true;
            listBoxRates.Location = new Point(553, 35);
            listBoxRates.Margin = new Padding(3, 2, 3, 2);
            listBoxRates.Name = "listBoxRates";
            listBoxRates.Size = new Size(334, 199);
            listBoxRates.TabIndex = 5;
            // 
            // listBoxUniversities
            // 
            listBoxUniversities.FormattingEnabled = true;
            listBoxUniversities.Location = new Point(160, 35);
            listBoxUniversities.Name = "listBoxUniversities";
            listBoxUniversities.Size = new Size(387, 199);
            listBoxUniversities.TabIndex = 6;
            // 
            // buttonCheckUniversities
            // 
            buttonCheckUniversities.Location = new Point(268, 6);
            buttonCheckUniversities.Name = "buttonCheckUniversities";
            buttonCheckUniversities.Size = new Size(178, 23);
            buttonCheckUniversities.TabIndex = 7;
            buttonCheckUniversities.Text = "Check Universities";
            buttonCheckUniversities.UseVisualStyleBackColor = true;
            buttonCheckUniversities.Click += buttonCheckUniversities_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 335);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(116, 335);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(101, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(443, 339);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(84, 15);
            lblDistance.TabIndex = 12;
            lblDistance.Text = "Distance: 0 km";
            // 
            // textBoxHost1
            // 
            textBoxHost1.Location = new Point(223, 336);
            textBoxHost1.Name = "textBoxHost1";
            textBoxHost1.Size = new Size(100, 23);
            textBoxHost1.TabIndex = 13;
            // 
            // textBoxHost2
            // 
            textBoxHost2.Location = new Point(329, 336);
            textBoxHost2.Name = "textBoxHost2";
            textBoxHost2.Size = new Size(100, 23);
            textBoxHost2.TabIndex = 14;
            // 
            // lblLat1
            // 
            lblLat1.AutoSize = true;
            lblLat1.Location = new Point(223, 362);
            lblLat1.Name = "lblLat1";
            lblLat1.Size = new Size(29, 15);
            lblLat1.TabIndex = 15;
            lblLat1.Text = "lat1:";
            // 
            // lblLon1
            // 
            lblLon1.AutoSize = true;
            lblLon1.Location = new Point(223, 377);
            lblLon1.Name = "lblLon1";
            lblLon1.Size = new Size(40, 15);
            lblLon1.TabIndex = 16;
            lblLon1.Text = "long1:";
            // 
            // lblLat2
            // 
            lblLat2.AutoSize = true;
            lblLat2.Location = new Point(329, 362);
            lblLat2.Name = "lblLat2";
            lblLat2.Size = new Size(29, 15);
            lblLat2.TabIndex = 17;
            lblLat2.Text = "lat2:";
            // 
            // lblLon2
            // 
            lblLon2.AutoSize = true;
            lblLon2.Location = new Point(329, 377);
            lblLon2.Name = "lblLon2";
            lblLon2.Size = new Size(40, 15);
            lblLon2.TabIndex = 18;
            lblLon2.Text = "long2:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 419);
            Controls.Add(lblLon2);
            Controls.Add(lblLat2);
            Controls.Add(lblLon1);
            Controls.Add(lblLat1);
            Controls.Add(textBoxHost2);
            Controls.Add(textBoxHost1);
            Controls.Add(lblDistance);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(buttonCheckUniversities);
            Controls.Add(listBoxUniversities);
            Controls.Add(listBoxRates);
            Controls.Add(buttonGetBankInfo);
            Controls.Add(listBoxAddresses);
            Controls.Add(buttonGetLastIp);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonGetIpInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetIpInfo;
        private TextBox textBoxOutput;
        private Button buttonGetLastIp;
        private ListBox listBoxAddresses;
        private Button buttonGetBankInfo;
        private ListBox listBoxRates;
        private ListBox listBoxUniversities;
        private Button buttonCheckUniversities;
        private Button btnClear;
        private Button btnCalculate;
        private Label lblDistance;
        private TextBox textBoxHost1;
        private TextBox textBoxHost2;
        private Label lblLat1;
        private Label lblLon1;
        private Label lblLat2;
        private Label lblLon2;
    }
}