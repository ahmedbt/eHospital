namespace eHospital
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Doctors = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.removeDoctorsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.removeListDoctorsButton = new System.Windows.Forms.Button();
            this.listDoctorsButton = new System.Windows.Forms.Button();
            this.addNewDoctor = new System.Windows.Forms.Button();
            this.logoutT1Button = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removePatientsButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.removeListPatientsButton = new System.Windows.Forms.Button();
            this.listPatientsButton = new System.Windows.Forms.Button();
            this.addNewPatient = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.logoutT2Button = new System.Windows.Forms.Button();
            this.Doctors.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // Doctors
            // 
            this.Doctors.Controls.Add(this.tabPage1);
            this.Doctors.Controls.Add(this.tabPage2);
            this.Doctors.Location = new System.Drawing.Point(12, 12);
            this.Doctors.Name = "Doctors";
            this.Doctors.SelectedIndex = 0;
            this.Doctors.Size = new System.Drawing.Size(645, 720);
            this.Doctors.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.removeDoctorsButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // removeDoctorsButton
            // 
            this.removeDoctorsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.removeDoctorsButton.Location = new System.Drawing.Point(480, 274);
            this.removeDoctorsButton.Name = "removeDoctorsButton";
            this.removeDoctorsButton.Size = new System.Drawing.Size(152, 42);
            this.removeDoctorsButton.TabIndex = 12;
            this.removeDoctorsButton.Text = "Remove";
            this.removeDoctorsButton.UseVisualStyleBackColor = false;
            this.removeDoctorsButton.Click += new System.EventHandler(this.removeDoctorsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(623, 357);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Here list of doctors will be displayed.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeListDoctorsButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listDoctorsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addNewDoctor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.logoutT1Button, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(161, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 162);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(319, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 162);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // removeListDoctorsButton
            // 
            this.removeListDoctorsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.removeListDoctorsButton.Location = new System.Drawing.Point(319, 190);
            this.removeListDoctorsButton.Name = "removeListDoctorsButton";
            this.removeListDoctorsButton.Size = new System.Drawing.Size(152, 43);
            this.removeListDoctorsButton.TabIndex = 7;
            this.removeListDoctorsButton.Text = "Remove doctor";
            this.removeListDoctorsButton.UseVisualStyleBackColor = false;
            this.removeListDoctorsButton.Click += new System.EventHandler(this.removeListDoctorsButton_Click);
            // 
            // listDoctorsButton
            // 
            this.listDoctorsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listDoctorsButton.Location = new System.Drawing.Point(161, 190);
            this.listDoctorsButton.Name = "listDoctorsButton";
            this.listDoctorsButton.Size = new System.Drawing.Size(152, 43);
            this.listDoctorsButton.TabIndex = 6;
            this.listDoctorsButton.Text = "List of doctor";
            this.listDoctorsButton.UseVisualStyleBackColor = false;
            this.listDoctorsButton.Click += new System.EventHandler(this.listDoctorsButton_Click);
            // 
            // addNewDoctor
            // 
            this.addNewDoctor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewDoctor.Location = new System.Drawing.Point(3, 190);
            this.addNewDoctor.Name = "addNewDoctor";
            this.addNewDoctor.Size = new System.Drawing.Size(152, 43);
            this.addNewDoctor.TabIndex = 5;
            this.addNewDoctor.Text = "Add new doctor";
            this.addNewDoctor.UseVisualStyleBackColor = false;
            this.addNewDoctor.Click += new System.EventHandler(this.addNewDoctor_Click);
            // 
            // logoutT1Button
            // 
            this.logoutT1Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logoutT1Button.Location = new System.Drawing.Point(477, 190);
            this.logoutT1Button.Name = "logoutT1Button";
            this.logoutT1Button.Size = new System.Drawing.Size(152, 43);
            this.logoutT1Button.TabIndex = 9;
            this.logoutT1Button.Text = "Log out";
            this.logoutT1Button.UseVisualStyleBackColor = false;
            this.logoutT1Button.Click += new System.EventHandler(this.logoutT1Button_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(477, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(152, 162);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removePatientsButton);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removePatientsButton
            // 
            this.removePatientsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.removePatientsButton.Location = new System.Drawing.Point(480, 275);
            this.removePatientsButton.Name = "removePatientsButton";
            this.removePatientsButton.Size = new System.Drawing.Size(152, 43);
            this.removePatientsButton.TabIndex = 13;
            this.removePatientsButton.Text = "Remove";
            this.removePatientsButton.UseVisualStyleBackColor = false;
            this.removePatientsButton.Click += new System.EventHandler(this.removePatientsButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(623, 357);
            this.dataGridView2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Here list of patients will be displayed.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.removeListPatientsButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.listPatientsButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.addNewPatient, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox10, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.logoutT2Button, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 260);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::eHospital.Properties.Resources.add_user;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(152, 162);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(161, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(152, 162);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(319, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(152, 162);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // removeListPatientsButton
            // 
            this.removeListPatientsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.removeListPatientsButton.Location = new System.Drawing.Point(319, 190);
            this.removeListPatientsButton.Name = "removeListPatientsButton";
            this.removeListPatientsButton.Size = new System.Drawing.Size(152, 43);
            this.removeListPatientsButton.TabIndex = 6;
            this.removeListPatientsButton.Text = "Remove patient";
            this.removeListPatientsButton.UseVisualStyleBackColor = false;
            this.removeListPatientsButton.Click += new System.EventHandler(this.removeListPatientsButton_Click);
            // 
            // listPatientsButton
            // 
            this.listPatientsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listPatientsButton.Location = new System.Drawing.Point(161, 190);
            this.listPatientsButton.Name = "listPatientsButton";
            this.listPatientsButton.Size = new System.Drawing.Size(152, 43);
            this.listPatientsButton.TabIndex = 5;
            this.listPatientsButton.Text = "List of patients";
            this.listPatientsButton.UseVisualStyleBackColor = false;
            this.listPatientsButton.Click += new System.EventHandler(this.listPatientsButton_Click);
            // 
            // addNewPatient
            // 
            this.addNewPatient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewPatient.Location = new System.Drawing.Point(3, 190);
            this.addNewPatient.Name = "addNewPatient";
            this.addNewPatient.Size = new System.Drawing.Size(152, 43);
            this.addNewPatient.TabIndex = 4;
            this.addNewPatient.Text = "Add new patient";
            this.addNewPatient.UseVisualStyleBackColor = false;
            this.addNewPatient.Click += new System.EventHandler(this.addNewPatient_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(477, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(152, 162);
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // logoutT2Button
            // 
            this.logoutT2Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logoutT2Button.Location = new System.Drawing.Point(477, 190);
            this.logoutT2Button.Name = "logoutT2Button";
            this.logoutT2Button.Size = new System.Drawing.Size(152, 43);
            this.logoutT2Button.TabIndex = 8;
            this.logoutT2Button.Text = "Log out";
            this.logoutT2Button.UseVisualStyleBackColor = false;
            this.logoutT2Button.Click += new System.EventHandler(this.logoutT2Button_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(665, 760);
            this.Controls.Add(this.Doctors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "eHospital Admin ";
            this.Doctors.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Doctors;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button logoutT1Button;
        private System.Windows.Forms.Button removeListDoctorsButton;
        private System.Windows.Forms.Button listDoctorsButton;
        private System.Windows.Forms.Button addNewDoctor;
        private System.Windows.Forms.Button logoutT2Button;
        private System.Windows.Forms.Button removeListPatientsButton;
        private System.Windows.Forms.Button listPatientsButton;
        private System.Windows.Forms.Button addNewPatient;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button removeDoctorsButton;
        private System.Windows.Forms.Button removePatientsButton;
    }
}