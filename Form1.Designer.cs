namespace ReflectionWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Object = new System.Windows.Forms.TextBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_ctors = new System.Windows.Forms.ListBox();
            this.lst_props = new System.Windows.Forms.ListBox();
            this.lst_methods = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Controls.Add(this.txt_Object);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen Bilgi Almak İstediğiniz Classın Tam Adını Giriniz";
            // 
            // txt_Object
            // 
            this.txt_Object.Location = new System.Drawing.Point(6, 19);
            this.txt_Object.Name = "txt_Object";
            this.txt_Object.Size = new System.Drawing.Size(655, 20);
            this.txt_Object.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(667, 16);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(117, 23);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ctors);
            this.groupBox2.Location = new System.Drawing.Point(41, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 435);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CTOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_props);
            this.groupBox3.Location = new System.Drawing.Point(268, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 435);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_methods);
            this.groupBox4.Location = new System.Drawing.Point(496, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 435);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Methods";
            // 
            // lst_ctors
            // 
            this.lst_ctors.FormattingEnabled = true;
            this.lst_ctors.Location = new System.Drawing.Point(6, 28);
            this.lst_ctors.Name = "lst_ctors";
            this.lst_ctors.Size = new System.Drawing.Size(188, 394);
            this.lst_ctors.TabIndex = 0;
            // 
            // lst_props
            // 
            this.lst_props.FormattingEnabled = true;
            this.lst_props.Location = new System.Drawing.Point(6, 28);
            this.lst_props.Name = "lst_props";
            this.lst_props.Size = new System.Drawing.Size(188, 394);
            this.lst_props.TabIndex = 1;
            // 
            // lst_methods
            // 
            this.lst_methods.FormattingEnabled = true;
            this.lst_methods.Location = new System.Drawing.Point(6, 28);
            this.lst_methods.Name = "lst_methods";
            this.lst_methods.Size = new System.Drawing.Size(188, 394);
            this.lst_methods.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 537);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reflection Win Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.TextBox txt_Object;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_ctors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_props;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lst_methods;
    }
}

