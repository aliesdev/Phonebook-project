
namespace MyProject
{
    partial class frmAddOrEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(596, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.txtFamily);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(547, 255);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات شخص";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(18, 71);
            this.txtAge.Name = "txtAge";
            this.txtAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAge.Size = new System.Drawing.Size(179, 22);
            this.txtAge.TabIndex = 26;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAge.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "آدرس :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "ایمیل :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "سن :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "فامیلی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "موبایل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "نام :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(18, 164);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(452, 75);
            this.txtAddress.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(452, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(291, 73);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(179, 22);
            this.txtMobile.TabIndex = 17;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(18, 29);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(179, 22);
            this.txtFamily.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(291, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 22);
            this.txtName.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(386, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 34);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شخص جدید";
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
    }
}