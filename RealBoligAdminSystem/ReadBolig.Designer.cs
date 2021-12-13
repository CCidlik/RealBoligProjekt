
namespace RealBolig
{
    partial class ReadBolig
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
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnIndlæsBolig = new System.Windows.Forms.Button();
            this.tbOmråde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Postnummer = new System.Windows.Forms.Label();
            this.tbPostnummer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgtDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boligBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet = new RealBolig.kaspermark_dk_db_realboligDataSet();
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRefreshBoligSøg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnUdskrivData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnUdprintHuseTilSalg = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            // 
            // boligBindingSource1
            // 
            this.boligBindingSource1.DataMember = "Bolig";
            // 
            // btnIndlæsBolig
            // 
            this.btnIndlæsBolig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndlæsBolig.Location = new System.Drawing.Point(1246, 74);
            this.btnIndlæsBolig.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnIndlæsBolig.Name = "btnIndlæsBolig";
            this.btnIndlæsBolig.Size = new System.Drawing.Size(285, 141);
            this.btnIndlæsBolig.TabIndex = 54;
            this.btnIndlæsBolig.Text = "Søg Bolig";
            this.btnIndlæsBolig.UseVisualStyleBackColor = true;
            this.btnIndlæsBolig.Click += new System.EventHandler(this.btnIndlæsBolig_Click);
            this.btnIndlæsBolig.MouseHover += new System.EventHandler(this.btnIndlæsBolig_MouseHover);
            // 
            // tbOmråde
            // 
            this.tbOmråde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOmråde.Location = new System.Drawing.Point(415, 76);
            this.tbOmråde.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbOmråde.Name = "tbOmråde";
            this.tbOmråde.Size = new System.Drawing.Size(776, 55);
            this.tbOmråde.TabIndex = 39;
            this.tbOmråde.TextChanged += new System.EventHandler(this.tbOmråde_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 38;
            this.label1.Text = "Indtast Område";
            // 
            // Postnummer
            // 
            this.Postnummer.AutoSize = true;
            this.Postnummer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Postnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postnummer.Location = new System.Drawing.Point(44, 161);
            this.Postnummer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Postnummer.Name = "Postnummer";
            this.Postnummer.Size = new System.Drawing.Size(257, 48);
            this.Postnummer.TabIndex = 56;
            this.Postnummer.Text = "Postnummer";
            // 
            // tbPostnummer
            // 
            this.tbPostnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostnummer.Location = new System.Drawing.Point(415, 152);
            this.tbPostnummer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbPostnummer.Name = "tbPostnummer";
            this.tbPostnummer.Size = new System.Drawing.Size(256, 55);
            this.tbPostnummer.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.solgtDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(147, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1638, 526);
            this.dataGridView1.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BiD";
            this.dataGridViewTextBoxColumn1.HeaderText = "BiD";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KiD";
            this.dataGridViewTextBoxColumn2.HeaderText = "KiD";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PostNR";
            this.dataGridViewTextBoxColumn3.HeaderText = "PostNR";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Område";
            this.dataGridViewTextBoxColumn5.HeaderText = "Område";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SalgsPris";
            this.dataGridViewTextBoxColumn6.HeaderText = "SalgsPris";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SalgsDato";
            this.dataGridViewTextBoxColumn7.HeaderText = "SalgsDato";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Kvm";
            this.dataGridViewTextBoxColumn8.HeaderText = "Kvm";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // solgtDataGridViewCheckBoxColumn
            // 
            this.solgtDataGridViewCheckBoxColumn.DataPropertyName = "Solgt";
            this.solgtDataGridViewCheckBoxColumn.HeaderText = "Solgt";
            this.solgtDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.solgtDataGridViewCheckBoxColumn.Name = "solgtDataGridViewCheckBoxColumn";
            // 
            // boligBindingSource2
            // 
            this.boligBindingSource2.DataMember = "Bolig";
            this.boligBindingSource2.DataSource = this.kaspermark_dk_db_realboligDataSet;
            // 
            // kaspermark_dk_db_realboligDataSet
            // 
            this.kaspermark_dk_db_realboligDataSet.DataSetName = "kaspermark_dk_db_realboligDataSet";
            this.kaspermark_dk_db_realboligDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnRefreshBoligSøg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnIndlæsBolig);
            this.panel1.Controls.Add(this.tbPostnummer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Postnummer);
            this.panel1.Controls.Add(this.tbOmråde);
            this.panel1.Location = new System.Drawing.Point(147, 694);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 625);
            this.panel1.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(838, 457);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 35);
            this.label5.TabIndex = 70;
            this.label5.Text = "Maximum Pris";
            // 
            // BtnRefreshBoligSøg
            // 
            this.BtnRefreshBoligSøg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefreshBoligSøg.Location = new System.Drawing.Point(1246, 236);
            this.BtnRefreshBoligSøg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnRefreshBoligSøg.Name = "BtnRefreshBoligSøg";
            this.BtnRefreshBoligSøg.Size = new System.Drawing.Size(285, 141);
            this.BtnRefreshBoligSøg.TabIndex = 1;
            this.BtnRefreshBoligSøg.Text = "Refresh Søgning";
            this.BtnRefreshBoligSøg.UseVisualStyleBackColor = true;
            this.BtnRefreshBoligSøg.Click += new System.EventHandler(this.BtnRefreshBoligSøg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 457);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 35);
            this.label6.TabIndex = 69;
            this.label6.Text = "Minimums Pris";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(845, 497);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(349, 54);
            this.textBox3.TabIndex = 68;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(415, 497);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(349, 54);
            this.textBox4.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 497);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 48);
            this.label7.TabIndex = 66;
            this.label7.Text = "Søg i Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(835, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 35);
            this.label4.TabIndex = 65;
            this.label4.Text = "Til Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 35);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fra Dato";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(842, 368);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 54);
            this.textBox2.TabIndex = 63;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(415, 368);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 54);
            this.textBox1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 48);
            this.label2.TabIndex = 61;
            this.label2.Text = "Søg i Periode";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(982, 236);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(212, 44);
            this.radioButton3.TabIndex = 60;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Al aktivitet";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(693, 236);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(278, 44);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Boliger til Salg";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(413, 236);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(272, 44);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Solgte Boliger";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnUdskrivData
            // 
            this.BtnUdskrivData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUdskrivData.Location = new System.Drawing.Point(845, 36);
            this.BtnUdskrivData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnUdskrivData.Name = "BtnUdskrivData";
            this.BtnUdskrivData.Size = new System.Drawing.Size(285, 141);
            this.BtnUdskrivData.TabIndex = 71;
            this.BtnUdskrivData.Text = "Udskriv Valgte Område Data";
            this.BtnUdskrivData.UseVisualStyleBackColor = true;
            this.BtnUdskrivData.Click += new System.EventHandler(this.BtnUdskrivData_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(147, 605);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1638, 91);
            this.panel2.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(511, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(651, 48);
            this.label8.TabIndex = 0;
            this.label8.Text = "SØG BOLIG OG UDSKRIV DATA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.BtnUdskrivData);
            this.panel3.Controls.Add(this.BtnUdprintHuseTilSalg);
            this.panel3.Location = new System.Drawing.Point(147, 1392);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1638, 221);
            this.panel3.TabIndex = 61;
            // 
            // BtnUdprintHuseTilSalg
            // 
            this.BtnUdprintHuseTilSalg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUdprintHuseTilSalg.Location = new System.Drawing.Point(415, 36);
            this.BtnUdprintHuseTilSalg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnUdprintHuseTilSalg.Name = "BtnUdprintHuseTilSalg";
            this.BtnUdprintHuseTilSalg.Size = new System.Drawing.Size(285, 141);
            this.BtnUdprintHuseTilSalg.TabIndex = 0;
            this.BtnUdprintHuseTilSalg.Text = "Udprint Alle Huse til salg";
            this.BtnUdprintHuseTilSalg.UseVisualStyleBackColor = true;
            this.BtnUdprintHuseTilSalg.Click += new System.EventHandler(this.BtnUdprintHuseTilSalg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(632, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 48);
            this.label9.TabIndex = 0;
            this.label9.Text = "UDSKRIV DATA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(145, 1318);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1638, 91);
            this.panel4.TabIndex = 62;
            // 
            // ReadBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(2044, 1660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ReadBolig";
            this.Text = "ReadBolig";
            this.Load += new System.EventHandler(this.ReadBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource boligBindingSource;
        private System.Windows.Forms.Button btnIndlæsBolig;
        private System.Windows.Forms.MaskedTextBox tbOmråde;
        private System.Windows.Forms.Label label1;
        //private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource1;
        //private kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn biDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.Label Postnummer;
        private System.Windows.Forms.TextBox tbPostnummer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource2;
        private kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solgtDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnUdskrivData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnRefreshBoligSøg;
        private System.Windows.Forms.Button BtnUdprintHuseTilSalg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}