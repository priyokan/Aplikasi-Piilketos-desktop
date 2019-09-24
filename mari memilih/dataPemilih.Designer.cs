namespace mari_memilih
{
    partial class dataPemilih
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.HasilPemilihan = new System.Windows.Forms.Button();
            this.BtndataKandidat = new System.Windows.Forms.Button();
            this.btndataPemilih = new System.Windows.Forms.Button();
            this.btnDataUSer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pilketosDataSet = new mari_memilih.pilketosDataSet();
            this.pemilihBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemilihTableAdapter = new mari_memilih.pilketosDataSetTableAdapters.PemilihTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePemilihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilketosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilihBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(-1, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Management peserta yang akan memilih";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(-1, 71);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(261, 41);
            this.panel8.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(148, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data pemilih";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(805, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 29);
            this.button4.TabIndex = 45;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(718, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 43;
            this.button2.Text = "Tambah";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.button5);
            this.PanelMenu.Controls.Add(this.HasilPemilihan);
            this.PanelMenu.Controls.Add(this.BtndataKandidat);
            this.PanelMenu.Controls.Add(this.btndataPemilih);
            this.PanelMenu.Controls.Add(this.btnDataUSer);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(262, 608);
            this.PanelMenu.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(13, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 54);
            this.panel2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(13, 541);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(246, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // HasilPemilihan
            // 
            this.HasilPemilihan.FlatAppearance.BorderSize = 0;
            this.HasilPemilihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HasilPemilihan.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasilPemilihan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HasilPemilihan.Location = new System.Drawing.Point(13, 381);
            this.HasilPemilihan.Name = "HasilPemilihan";
            this.HasilPemilihan.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.HasilPemilihan.Size = new System.Drawing.Size(246, 55);
            this.HasilPemilihan.TabIndex = 5;
            this.HasilPemilihan.Text = "Hasil Pemilihan";
            this.HasilPemilihan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HasilPemilihan.UseVisualStyleBackColor = true;
            this.HasilPemilihan.Click += new System.EventHandler(this.HasilPemilihan_Click);
            // 
            // BtndataKandidat
            // 
            this.BtndataKandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtndataKandidat.FlatAppearance.BorderSize = 0;
            this.BtndataKandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtndataKandidat.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtndataKandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtndataKandidat.Location = new System.Drawing.Point(13, 320);
            this.BtndataKandidat.Name = "BtndataKandidat";
            this.BtndataKandidat.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtndataKandidat.Size = new System.Drawing.Size(246, 55);
            this.BtndataKandidat.TabIndex = 4;
            this.BtndataKandidat.Text = "Data Kandidat";
            this.BtndataKandidat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtndataKandidat.UseVisualStyleBackColor = false;
            // 
            // btndataPemilih
            // 
            this.btndataPemilih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btndataPemilih.FlatAppearance.BorderSize = 0;
            this.btndataPemilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndataPemilih.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndataPemilih.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndataPemilih.Location = new System.Drawing.Point(13, 259);
            this.btndataPemilih.Name = "btndataPemilih";
            this.btndataPemilih.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btndataPemilih.Size = new System.Drawing.Size(246, 55);
            this.btndataPemilih.TabIndex = 3;
            this.btndataPemilih.Text = "Data Pemilih";
            this.btndataPemilih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndataPemilih.UseVisualStyleBackColor = false;
            // 
            // btnDataUSer
            // 
            this.btnDataUSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDataUSer.FlatAppearance.BorderSize = 0;
            this.btnDataUSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataUSer.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataUSer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDataUSer.Location = new System.Drawing.Point(13, 198);
            this.btnDataUSer.Name = "btnDataUSer";
            this.btnDataUSer.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDataUSer.Size = new System.Drawing.Size(246, 55);
            this.btnDataUSer.TabIndex = 0;
            this.btnDataUSer.Text = "Data User";
            this.btnDataUSer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataUSer.UseVisualStyleBackColor = false;
            this.btnDataUSer.Click += new System.EventHandler(this.BtnDataUSer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 41);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 41);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mari_memilih.Properties.Resources.circled_chevron_left_50px;
            this.pictureBox2.Location = new System.Drawing.Point(-28, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mari_memilih.Properties.Resources.menu_2_filled_50px;
            this.pictureBox1.Location = new System.Drawing.Point(-28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodePemilihDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pemilihBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(51, 202);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(641, 300);
            this.dataGridView2.TabIndex = 48;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // pilketosDataSet
            // 
            this.pilketosDataSet.DataSetName = "pilketosDataSet";
            this.pilketosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemilihBindingSource
            // 
            this.pemilihBindingSource.DataMember = "Pemilih";
            this.pemilihBindingSource.DataSource = this.pilketosDataSet;
            // 
            // pemilihTableAdapter
            // 
            this.pemilihTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 43;
            // 
            // kodePemilihDataGridViewTextBoxColumn
            // 
            this.kodePemilihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodePemilihDataGridViewTextBoxColumn.DataPropertyName = "kodePemilih";
            this.kodePemilihDataGridViewTextBoxColumn.HeaderText = "kodePemilih";
            this.kodePemilihDataGridViewTextBoxColumn.Name = "kodePemilihDataGridViewTextBoxColumn";
            this.kodePemilihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPemilih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 606);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataPemilih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dataPemilih";
            this.Load += new System.EventHandler(this.DataPemilih_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilketosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilihBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button HasilPemilihan;
        private System.Windows.Forms.Button BtndataKandidat;
        private System.Windows.Forms.Button btndataPemilih;
        private System.Windows.Forms.Button btnDataUSer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private pilketosDataSet pilketosDataSet;
        private System.Windows.Forms.BindingSource pemilihBindingSource;
        private pilketosDataSetTableAdapters.PemilihTableAdapter pemilihTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePemilihDataGridViewTextBoxColumn;
    }
}