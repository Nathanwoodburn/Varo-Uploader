namespace Varo_Uploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.domainlistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletedomainbutton = new System.Windows.Forms.Button();
            this.importdomainbutton = new System.Windows.Forms.Button();
            this.adddomainbutton = new System.Windows.Forms.Button();
            this.adddomaintextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearlogsbutton = new System.Windows.Forms.Button();
            this.logtextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.varotestbutton = new System.Windows.Forms.Button();
            this.varokeytextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.varourltextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hsdtestbutton = new System.Windows.Forms.Button();
            this.hsdpasswordtextBox = new System.Windows.Forms.TextBox();
            this.hsdwallettextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hsdkeytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hsdregtestbutton = new System.Windows.Forms.Button();
            this.hsdmainnetbutton = new System.Windows.Forms.Button();
            this.hsdurltextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addtobobbutton = new System.Windows.Forms.Button();
            this.addvarobutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainlistBox
            // 
            this.domainlistBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.domainlistBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.domainlistBox.FormattingEnabled = true;
            this.domainlistBox.ItemHeight = 15;
            this.domainlistBox.Location = new System.Drawing.Point(136, 19);
            this.domainlistBox.Name = "domainlistBox";
            this.domainlistBox.Size = new System.Drawing.Size(202, 402);
            this.domainlistBox.TabIndex = 1;
            this.domainlistBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletedomainbutton);
            this.groupBox1.Controls.Add(this.importdomainbutton);
            this.groupBox1.Controls.Add(this.adddomainbutton);
            this.groupBox1.Controls.Add(this.adddomaintextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.domainlistBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(661, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 424);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domains";
            // 
            // deletedomainbutton
            // 
            this.deletedomainbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deletedomainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletedomainbutton.Location = new System.Drawing.Point(6, 189);
            this.deletedomainbutton.Name = "deletedomainbutton";
            this.deletedomainbutton.Size = new System.Drawing.Size(75, 23);
            this.deletedomainbutton.TabIndex = 6;
            this.deletedomainbutton.Text = "Delete";
            this.deletedomainbutton.UseVisualStyleBackColor = false;
            this.deletedomainbutton.Click += new System.EventHandler(this.deletedomainbutton_Click);
            // 
            // importdomainbutton
            // 
            this.importdomainbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.importdomainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importdomainbutton.Location = new System.Drawing.Point(6, 22);
            this.importdomainbutton.Name = "importdomainbutton";
            this.importdomainbutton.Size = new System.Drawing.Size(75, 23);
            this.importdomainbutton.TabIndex = 5;
            this.importdomainbutton.Text = "Import";
            this.importdomainbutton.UseVisualStyleBackColor = false;
            this.importdomainbutton.Click += new System.EventHandler(this.importdomainbutton_Click);
            // 
            // adddomainbutton
            // 
            this.adddomainbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adddomainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddomainbutton.Location = new System.Drawing.Point(6, 121);
            this.adddomainbutton.Name = "adddomainbutton";
            this.adddomainbutton.Size = new System.Drawing.Size(75, 23);
            this.adddomainbutton.TabIndex = 4;
            this.adddomainbutton.TabStop = false;
            this.adddomainbutton.Text = "Add";
            this.adddomainbutton.UseVisualStyleBackColor = false;
            this.adddomainbutton.Click += new System.EventHandler(this.adddomainbutton_Click);
            // 
            // adddomaintextbox
            // 
            this.adddomaintextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adddomaintextbox.Location = new System.Drawing.Point(6, 92);
            this.adddomaintextbox.Name = "adddomaintextbox";
            this.adddomaintextbox.Size = new System.Drawing.Size(124, 23);
            this.adddomaintextbox.TabIndex = 3;
            this.adddomaintextbox.TabStop = false;
            this.adddomaintextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adddomaintextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add domain:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearlogsbutton);
            this.groupBox2.Controls.Add(this.logtextbox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // clearlogsbutton
            // 
            this.clearlogsbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearlogsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearlogsbutton.Location = new System.Drawing.Point(884, 21);
            this.clearlogsbutton.Name = "clearlogsbutton";
            this.clearlogsbutton.Size = new System.Drawing.Size(106, 23);
            this.clearlogsbutton.TabIndex = 5;
            this.clearlogsbutton.Text = "Clear logs";
            this.clearlogsbutton.UseVisualStyleBackColor = false;
            this.clearlogsbutton.Click += new System.EventHandler(this.clearlogsbutton_Click);
            // 
            // logtextbox
            // 
            this.logtextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logtextbox.Location = new System.Drawing.Point(6, 22);
            this.logtextbox.Multiline = true;
            this.logtextbox.Name = "logtextbox";
            this.logtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtextbox.Size = new System.Drawing.Size(872, 98);
            this.logtextbox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.varotestbutton);
            this.groupBox3.Controls.Add(this.varokeytextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.varourltextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Varo Settings";
            // 
            // varotestbutton
            // 
            this.varotestbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.varotestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.varotestbutton.Location = new System.Drawing.Point(260, 77);
            this.varotestbutton.Name = "varotestbutton";
            this.varotestbutton.Size = new System.Drawing.Size(75, 23);
            this.varotestbutton.TabIndex = 4;
            this.varotestbutton.Text = "Test";
            this.varotestbutton.UseVisualStyleBackColor = false;
            this.varotestbutton.Click += new System.EventHandler(this.varotestbutton_Click);
            // 
            // varokeytextBox
            // 
            this.varokeytextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.varokeytextBox.Location = new System.Drawing.Point(64, 48);
            this.varokeytextBox.Name = "varokeytextBox";
            this.varokeytextBox.Size = new System.Drawing.Size(271, 23);
            this.varokeytextBox.TabIndex = 3;
            this.varokeytextBox.Text = "cd605a0ef87747e498b943a621d096a8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "API Key:";
            // 
            // varourltextBox
            // 
            this.varourltextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.varourltextBox.Location = new System.Drawing.Point(64, 19);
            this.varourltextBox.Name = "varourltextBox";
            this.varourltextBox.Size = new System.Drawing.Size(271, 23);
            this.varourltextBox.TabIndex = 1;
            this.varourltextBox.Text = "https://reg.woodburn.au/api";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "API URL:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hsdtestbutton);
            this.groupBox4.Controls.Add(this.hsdpasswordtextBox);
            this.groupBox4.Controls.Add(this.hsdwallettextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.hsdkeytextBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.hsdregtestbutton);
            this.groupBox4.Controls.Add(this.hsdmainnetbutton);
            this.groupBox4.Controls.Add(this.hsdurltextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 173);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HSD Settings";
            // 
            // hsdtestbutton
            // 
            this.hsdtestbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdtestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsdtestbutton.Location = new System.Drawing.Point(260, 45);
            this.hsdtestbutton.Name = "hsdtestbutton";
            this.hsdtestbutton.Size = new System.Drawing.Size(75, 23);
            this.hsdtestbutton.TabIndex = 10;
            this.hsdtestbutton.Text = "Test";
            this.hsdtestbutton.UseVisualStyleBackColor = false;
            this.hsdtestbutton.Click += new System.EventHandler(this.hsdtestbutton_ClickAsync);
            // 
            // hsdpasswordtextBox
            // 
            this.hsdpasswordtextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdpasswordtextBox.Location = new System.Drawing.Point(64, 134);
            this.hsdpasswordtextBox.Name = "hsdpasswordtextBox";
            this.hsdpasswordtextBox.Size = new System.Drawing.Size(271, 23);
            this.hsdpasswordtextBox.TabIndex = 9;
            this.hsdpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // hsdwallettextBox
            // 
            this.hsdwallettextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdwallettextBox.Location = new System.Drawing.Point(64, 105);
            this.hsdwallettextBox.Name = "hsdwallettextBox";
            this.hsdwallettextBox.Size = new System.Drawing.Size(271, 23);
            this.hsdwallettextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Wallet:";
            // 
            // hsdkeytextBox
            // 
            this.hsdkeytextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdkeytextBox.Location = new System.Drawing.Point(64, 76);
            this.hsdkeytextBox.Name = "hsdkeytextBox";
            this.hsdkeytextBox.Size = new System.Drawing.Size(271, 23);
            this.hsdkeytextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "API Key:";
            // 
            // hsdregtestbutton
            // 
            this.hsdregtestbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdregtestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsdregtestbutton.Location = new System.Drawing.Point(145, 45);
            this.hsdregtestbutton.Name = "hsdregtestbutton";
            this.hsdregtestbutton.Size = new System.Drawing.Size(75, 23);
            this.hsdregtestbutton.TabIndex = 3;
            this.hsdregtestbutton.Text = "Regtest";
            this.hsdregtestbutton.UseVisualStyleBackColor = false;
            this.hsdregtestbutton.Click += new System.EventHandler(this.hsdregtestbutton_Click);
            // 
            // hsdmainnetbutton
            // 
            this.hsdmainnetbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdmainnetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsdmainnetbutton.Location = new System.Drawing.Point(64, 45);
            this.hsdmainnetbutton.Name = "hsdmainnetbutton";
            this.hsdmainnetbutton.Size = new System.Drawing.Size(75, 23);
            this.hsdmainnetbutton.TabIndex = 2;
            this.hsdmainnetbutton.Text = "Mainnet";
            this.hsdmainnetbutton.UseVisualStyleBackColor = false;
            this.hsdmainnetbutton.Click += new System.EventHandler(this.hsdmainnetbutton_Click);
            // 
            // hsdurltextBox
            // 
            this.hsdurltextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsdurltextBox.Location = new System.Drawing.Point(64, 16);
            this.hsdurltextBox.Name = "hsdurltextBox";
            this.hsdurltextBox.Size = new System.Drawing.Size(271, 23);
            this.hsdurltextBox.TabIndex = 1;
            this.hsdurltextBox.Text = "127.0.0.1:12039";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP:Port";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addtobobbutton);
            this.groupBox5.Controls.Add(this.addvarobutton);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 124);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // addtobobbutton
            // 
            this.addtobobbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addtobobbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtobobbutton.Location = new System.Drawing.Point(6, 51);
            this.addtobobbutton.Name = "addtobobbutton";
            this.addtobobbutton.Size = new System.Drawing.Size(133, 23);
            this.addtobobbutton.TabIndex = 0;
            this.addtobobbutton.Text = "Add records to Bob";
            this.addtobobbutton.UseVisualStyleBackColor = false;
            this.addtobobbutton.Click += new System.EventHandler(this.addtobobbutton_ClickAsync);
            // 
            // addvarobutton
            // 
            this.addvarobutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addvarobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addvarobutton.Location = new System.Drawing.Point(6, 22);
            this.addvarobutton.Name = "addvarobutton";
            this.addvarobutton.Size = new System.Drawing.Size(133, 23);
            this.addvarobutton.TabIndex = 0;
            this.addvarobutton.Text = "Add domains to varo";
            this.addvarobutton.UseVisualStyleBackColor = false;
            this.addvarobutton.Click += new System.EventHandler(this.addvarobutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1002, 556);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Varo Uploader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox domainlistBox;
        private GroupBox groupBox1;
        private Button adddomainbutton;
        private TextBox adddomaintextbox;
        private Label label1;
        private GroupBox groupBox2;
        private Button clearlogsbutton;
        private TextBox logtextbox;
        private Button importdomainbutton;
        private Button deletedomainbutton;
        private GroupBox groupBox3;
        private TextBox varokeytextBox;
        private Label label3;
        private TextBox varourltextBox;
        private Label label2;
        private Button varotestbutton;
        private GroupBox groupBox4;
        private TextBox hsdkeytextBox;
        private Label label5;
        private Button hsdregtestbutton;
        private Button hsdmainnetbutton;
        private TextBox hsdurltextBox;
        private Label label4;
        private Button hsdtestbutton;
        private TextBox hsdpasswordtextBox;
        private TextBox hsdwallettextBox;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private Button addtobobbutton;
        private Button addvarobutton;
    }
}