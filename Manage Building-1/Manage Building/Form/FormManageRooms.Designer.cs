namespace Manage_Building
{
    partial class FormManageRooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioLec = new System.Windows.Forms.RadioButton();
            this.radioLab = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCapacity = new System.Windows.Forms.ComboBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(191, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(664, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(552, 606);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DeleteSelection);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(392, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.UpdateSelection);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room name:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(179, 455);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 23);
            this.textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 146);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            // 
            // radioLec
            // 
            this.radioLec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioLec.AutoSize = true;
            this.radioLec.Location = new System.Drawing.Point(610, 530);
            this.radioLec.Name = "radioLec";
            this.radioLec.Size = new System.Drawing.Size(88, 19);
            this.radioLec.TabIndex = 6;
            this.radioLec.TabStop = true;
            this.radioLec.Text = "Lecture Hall";
            this.radioLec.UseVisualStyleBackColor = true;
            // 
            // radioLab
            // 
            this.radioLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioLab.AutoSize = true;
            this.radioLab.Location = new System.Drawing.Point(610, 505);
            this.radioLab.Name = "radioLab";
            this.radioLab.Size = new System.Drawing.Size(82, 19);
            this.radioLab.TabIndex = 5;
            this.radioLab.TabStop = true;
            this.radioLab.Text = "Laboratory";
            this.radioLab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Room type:";
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCapacity.Location = new System.Drawing.Point(179, 517);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(329, 23);
            this.cmbCapacity.TabIndex = 4;
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.picHome.Image = global::Manage_Building.Properties.Resources.home_127px;
            this.picHome.Location = new System.Drawing.Point(12, 193);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(35, 35);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 26;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBack.Image = global::Manage_Building.Properties.Resources.back_to_127px;
            this.picBack.Location = new System.Drawing.Point(12, 152);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(35, 35);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 27;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(526, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(329, 23);
            this.textBox2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Room ID:";
            // 
            // FormManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 725);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbCapacity);
            this.Controls.Add(this.radioLec);
            this.Controls.Add(this.radioLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormManageRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Rooms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioLec;
        private System.Windows.Forms.RadioButton radioLab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCapacity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}