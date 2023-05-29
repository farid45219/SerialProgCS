namespace serial_prog
{
    partial class SerialProg
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
            this.components = new System.ComponentModel.Container();
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.chkboxSerialPort = new System.Windows.Forms.ComboBox();
            this.chkboxSerialSpeed = new System.Windows.Forms.ComboBox();
            this.btnUploadFimrware = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rchtboxBrowseFile = new System.Windows.Forms.RichTextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnSerialView = new System.Windows.Forms.Button();
            this.tbctrlProgrammer = new System.Windows.Forms.TabControl();
            this.tbpgProgrammer = new System.Windows.Forms.TabPage();
            this.tbpgSerialView = new System.Windows.Forms.TabPage();
            this.tbpgInfo = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbctrlProgrammer.SuspendLayout();
            this.tbpgProgrammer.SuspendLayout();
            this.tbpgInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkboxSerialPort
            // 
            this.chkboxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chkboxSerialPort.FormattingEnabled = true;
            this.chkboxSerialPort.Location = new System.Drawing.Point(10, 55);
            this.chkboxSerialPort.Name = "chkboxSerialPort";
            this.chkboxSerialPort.Size = new System.Drawing.Size(200, 21);
            this.chkboxSerialPort.TabIndex = 0;
            this.chkboxSerialPort.SelectedIndexChanged += new System.EventHandler(this.chkboxSerialPort_SelectedIndexChanged);
            this.chkboxSerialPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkboxSerialSpeed_MouseClick);
            // 
            // chkboxSerialSpeed
            // 
            this.chkboxSerialSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chkboxSerialSpeed.FormattingEnabled = true;
            this.chkboxSerialSpeed.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.chkboxSerialSpeed.Location = new System.Drawing.Point(244, 55);
            this.chkboxSerialSpeed.Name = "chkboxSerialSpeed";
            this.chkboxSerialSpeed.Size = new System.Drawing.Size(174, 21);
            this.chkboxSerialSpeed.TabIndex = 1;
            this.chkboxSerialSpeed.SelectedIndexChanged += new System.EventHandler(this.chkboxSerialSpeed_SelectedIndexChanged);
            // 
            // btnUploadFimrware
            // 
            this.btnUploadFimrware.Location = new System.Drawing.Point(435, 49);
            this.btnUploadFimrware.Name = "btnUploadFimrware";
            this.btnUploadFimrware.Size = new System.Drawing.Size(100, 31);
            this.btnUploadFimrware.TabIndex = 2;
            this.btnUploadFimrware.Text = "Upload Fimrware";
            this.btnUploadFimrware.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // rchtboxBrowseFile
            // 
            this.rchtboxBrowseFile.Location = new System.Drawing.Point(8, 13);
            this.rchtboxBrowseFile.Name = "rchtboxBrowseFile";
            this.rchtboxBrowseFile.Size = new System.Drawing.Size(410, 29);
            this.rchtboxBrowseFile.TabIndex = 4;
            this.rchtboxBrowseFile.Text = "";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(435, 13);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(100, 29);
            this.btnBrowseFile.TabIndex = 5;
            this.btnBrowseFile.Text = "Browse File";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            // 
            // btnSerialView
            // 
            this.btnSerialView.Location = new System.Drawing.Point(222, 35);
            this.btnSerialView.Name = "btnSerialView";
            this.btnSerialView.Size = new System.Drawing.Size(70, 31);
            this.btnSerialView.TabIndex = 6;
            this.btnSerialView.Text = "Serial View";
            this.btnSerialView.UseVisualStyleBackColor = true;
            // 
            // tbctrlProgrammer
            // 
            this.tbctrlProgrammer.Controls.Add(this.tbpgProgrammer);
            this.tbctrlProgrammer.Controls.Add(this.tbpgSerialView);
            this.tbctrlProgrammer.Controls.Add(this.tbpgInfo);
            this.tbctrlProgrammer.Location = new System.Drawing.Point(12, 12);
            this.tbctrlProgrammer.Name = "tbctrlProgrammer";
            this.tbctrlProgrammer.SelectedIndex = 0;
            this.tbctrlProgrammer.Size = new System.Drawing.Size(566, 181);
            this.tbctrlProgrammer.TabIndex = 7;
            // 
            // tbpgProgrammer
            // 
            this.tbpgProgrammer.Controls.Add(this.rchtboxBrowseFile);
            this.tbpgProgrammer.Controls.Add(this.chkboxSerialPort);
            this.tbpgProgrammer.Controls.Add(this.progressBar1);
            this.tbpgProgrammer.Controls.Add(this.btnBrowseFile);
            this.tbpgProgrammer.Controls.Add(this.chkboxSerialSpeed);
            this.tbpgProgrammer.Controls.Add(this.btnUploadFimrware);
            this.tbpgProgrammer.Location = new System.Drawing.Point(4, 22);
            this.tbpgProgrammer.Name = "tbpgProgrammer";
            this.tbpgProgrammer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgProgrammer.Size = new System.Drawing.Size(558, 155);
            this.tbpgProgrammer.TabIndex = 0;
            this.tbpgProgrammer.Text = "Programmer";
            this.tbpgProgrammer.UseVisualStyleBackColor = true;
            // 
            // tbpgSerialView
            // 
            this.tbpgSerialView.Location = new System.Drawing.Point(4, 22);
            this.tbpgSerialView.Name = "tbpgSerialView";
            this.tbpgSerialView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSerialView.Size = new System.Drawing.Size(558, 155);
            this.tbpgSerialView.TabIndex = 1;
            this.tbpgSerialView.Text = "Serial View";
            this.tbpgSerialView.UseVisualStyleBackColor = true;
            // 
            // tbpgInfo
            // 
            this.tbpgInfo.Controls.Add(this.linkLabel2);
            this.tbpgInfo.Controls.Add(this.linkLabel1);
            this.tbpgInfo.Controls.Add(this.label3);
            this.tbpgInfo.Controls.Add(this.label2);
            this.tbpgInfo.Controls.Add(this.label1);
            this.tbpgInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpgInfo.Name = "tbpgInfo";
            this.tbpgInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgInfo.Size = new System.Drawing.Size(558, 155);
            this.tbpgInfo.TabIndex = 2;
            this.tbpgInfo.Text = "Info";
            this.tbpgInfo.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(70, 109);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(156, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/farid132097";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(70, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "faridmdislam@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "B.Sc. in Mechanical Engineering (RUET)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Md. Faridul Islam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed By-";
            // 
            // SerialProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 206);
            this.Controls.Add(this.tbctrlProgrammer);
            this.Controls.Add(this.btnSerialView);
            this.Name = "SerialProg";
            this.Text = "Serial Programmer & Debugger";
            this.tbctrlProgrammer.ResumeLayout(false);
            this.tbpgProgrammer.ResumeLayout(false);
            this.tbpgInfo.ResumeLayout(false);
            this.tbpgInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.ComboBox chkboxSerialPort;
        private System.Windows.Forms.ComboBox chkboxSerialSpeed;
        private System.Windows.Forms.Button btnUploadFimrware;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox rchtboxBrowseFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnSerialView;
        private System.Windows.Forms.TabControl tbctrlProgrammer;
        private System.Windows.Forms.TabPage tbpgProgrammer;
        private System.Windows.Forms.TabPage tbpgSerialView;
        private System.Windows.Forms.TabPage tbpgInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

