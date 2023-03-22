namespace SerializationAssignment
{
    partial class Form1
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
            this.txtstuname = new System.Windows.Forms.TextBox();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtstuname
            // 
            this.txtstuname.Location = new System.Drawing.Point(322, 119);
            this.txtstuname.Name = "txtstuname";
            this.txtstuname.Size = new System.Drawing.Size(100, 26);
            this.txtstuname.TabIndex = 27;
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(322, 206);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(100, 26);
            this.txtpercentage.TabIndex = 26;
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(322, 49);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(100, 26);
            this.txtrollno.TabIndex = 25;
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(571, 355);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(137, 46);
            this.btnJSONRead.TabIndex = 24;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(571, 285);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(137, 46);
            this.btnJSONWrite.TabIndex = 23;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(254, 355);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(137, 46);
            this.btnXMLRead.TabIndex = 22;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(410, 355);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(137, 46);
            this.btnSOAPRead.TabIndex = 21;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(410, 285);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(137, 46);
            this.btnSOAPWrite.TabIndex = 20;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(254, 285);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(137, 46);
            this.btnXMLWrite.TabIndex = 19;
            this.btnXMLWrite.Text = " XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(92, 355);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(137, 46);
            this.btnBinaryRead.TabIndex = 18;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(92, 285);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(137, 46);
            this.btnBinaryWrite.TabIndex = 17;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Roll No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtstuname);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstuname;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

