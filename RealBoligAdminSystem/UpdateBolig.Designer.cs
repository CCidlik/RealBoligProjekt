
namespace RealBolig
{
    partial class UpdateBolig
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
            this.tabPageBoliger = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.områdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgtDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet = new RealBolig.kaspermark_dk_db_realboligDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKøber = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.biDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet1 = new RealBolig.kaspermark_dk_db_realboligDataSet1();
            this.btnOpdaterBolig = new System.Windows.Forms.Button();
            this.mSalgsPrisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mBiDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbBoligSolgt = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mKøbsDatoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mKøbsPrisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mKøberIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter();
            this.bolig_StatusTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet1TableAdapters.Bolig_StatusTableAdapter();
            this.tabPageBoliger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageKøber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageBoliger
            // 
            this.tabPageBoliger.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageBoliger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageBoliger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageBoliger.Controls.Add(this.dataGridView1);
            this.tabPageBoliger.Location = new System.Drawing.Point(4, 25);
            this.tabPageBoliger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBoliger.Name = "tabPageBoliger";
            this.tabPageBoliger.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBoliger.Size = new System.Drawing.Size(928, 261);
            this.tabPageBoliger.TabIndex = 0;
            this.tabPageBoliger.Text = "Boliger";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biDDataGridViewTextBoxColumn,
            this.kiDDataGridViewTextBoxColumn,
            this.postNRDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.områdeDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.salgsDatoDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn,
            this.solgtDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(918, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // biDDataGridViewTextBoxColumn
            // 
            this.biDDataGridViewTextBoxColumn.DataPropertyName = "BiD";
            this.biDDataGridViewTextBoxColumn.HeaderText = "BiD";
            this.biDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biDDataGridViewTextBoxColumn.Name = "biDDataGridViewTextBoxColumn";
            this.biDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiDDataGridViewTextBoxColumn
            // 
            this.kiDDataGridViewTextBoxColumn.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiDDataGridViewTextBoxColumn.Name = "kiDDataGridViewTextBoxColumn";
            this.kiDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postNRDataGridViewTextBoxColumn
            // 
            this.postNRDataGridViewTextBoxColumn.DataPropertyName = "PostNR";
            this.postNRDataGridViewTextBoxColumn.HeaderText = "PostNR";
            this.postNRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postNRDataGridViewTextBoxColumn.Name = "postNRDataGridViewTextBoxColumn";
            this.postNRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // områdeDataGridViewTextBoxColumn
            // 
            this.områdeDataGridViewTextBoxColumn.DataPropertyName = "Område";
            this.områdeDataGridViewTextBoxColumn.HeaderText = "Område";
            this.områdeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.områdeDataGridViewTextBoxColumn.Name = "områdeDataGridViewTextBoxColumn";
            this.områdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "SalgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "SalgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            this.salgsPrisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salgsDatoDataGridViewTextBoxColumn
            // 
            this.salgsDatoDataGridViewTextBoxColumn.DataPropertyName = "SalgsDato";
            this.salgsDatoDataGridViewTextBoxColumn.HeaderText = "SalgsDato";
            this.salgsDatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salgsDatoDataGridViewTextBoxColumn.Name = "salgsDatoDataGridViewTextBoxColumn";
            this.salgsDatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "Kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "Kvm";
            this.kvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            this.kvmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solgtDataGridViewCheckBoxColumn
            // 
            this.solgtDataGridViewCheckBoxColumn.DataPropertyName = "Solgt";
            this.solgtDataGridViewCheckBoxColumn.HeaderText = "Solgt";
            this.solgtDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.solgtDataGridViewCheckBoxColumn.Name = "solgtDataGridViewCheckBoxColumn";
            this.solgtDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet;
            // 
            // kaspermark_dk_db_realboligDataSet
            // 
            this.kaspermark_dk_db_realboligDataSet.DataSetName = "kaspermark_dk_db_realboligDataSet";
            this.kaspermark_dk_db_realboligDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBoliger);
            this.tabControl1.Controls.Add(this.tabPageKøber);
            this.tabControl1.Location = new System.Drawing.Point(84, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 290);
            this.tabControl1.TabIndex = 72;
            // 
            // tabPageKøber
            // 
            this.tabPageKøber.Controls.Add(this.dataGridView2);
            this.tabPageKøber.Location = new System.Drawing.Point(4, 25);
            this.tabPageKøber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageKøber.Name = "tabPageKøber";
            this.tabPageKøber.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageKøber.Size = new System.Drawing.Size(928, 261);
            this.tabPageKøber.TabIndex = 1;
            this.tabPageKøber.Text = "Køber";
            this.tabPageKøber.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biDDataGridViewTextBoxColumn1,
            this.kiDDataGridViewTextBoxColumn1,
            this.handelsPrisDataGridViewTextBoxColumn,
            this.handelsDatoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.boligStatusBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(920, 253);
            this.dataGridView2.TabIndex = 0;
            // 
            // biDDataGridViewTextBoxColumn1
            // 
            this.biDDataGridViewTextBoxColumn1.DataPropertyName = "BiD";
            this.biDDataGridViewTextBoxColumn1.HeaderText = "BiD";
            this.biDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.biDDataGridViewTextBoxColumn1.Name = "biDDataGridViewTextBoxColumn1";
            this.biDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kiDDataGridViewTextBoxColumn1
            // 
            this.kiDDataGridViewTextBoxColumn1.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn1.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kiDDataGridViewTextBoxColumn1.Name = "kiDDataGridViewTextBoxColumn1";
            this.kiDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // handelsPrisDataGridViewTextBoxColumn
            // 
            this.handelsPrisDataGridViewTextBoxColumn.DataPropertyName = "HandelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.HeaderText = "HandelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.handelsPrisDataGridViewTextBoxColumn.Name = "handelsPrisDataGridViewTextBoxColumn";
            this.handelsPrisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handelsDatoDataGridViewTextBoxColumn
            // 
            this.handelsDatoDataGridViewTextBoxColumn.DataPropertyName = "HandelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.HeaderText = "HandelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.handelsDatoDataGridViewTextBoxColumn.Name = "handelsDatoDataGridViewTextBoxColumn";
            this.handelsDatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boligStatusBindingSource
            // 
            this.boligStatusBindingSource.DataMember = "Bolig_Status";
            this.boligStatusBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet1;
            // 
            // kaspermark_dk_db_realboligDataSet1
            // 
            this.kaspermark_dk_db_realboligDataSet1.DataSetName = "kaspermark_dk_db_realboligDataSet1";
            this.kaspermark_dk_db_realboligDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOpdaterBolig
            // 
            this.btnOpdaterBolig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpdaterBolig.Location = new System.Drawing.Point(557, 412);
            this.btnOpdaterBolig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpdaterBolig.Name = "btnOpdaterBolig";
            this.btnOpdaterBolig.Size = new System.Drawing.Size(260, 96);
            this.btnOpdaterBolig.TabIndex = 71;
            this.btnOpdaterBolig.Text = "Opdater Bolig";
            this.btnOpdaterBolig.UseVisualStyleBackColor = true;
            this.btnOpdaterBolig.Click += new System.EventHandler(this.btnOpdaterBolig_Click);
            // 
            // mSalgsPrisTextBox
            // 
            this.mSalgsPrisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSalgsPrisTextBox.Location = new System.Drawing.Point(283, 474);
            this.mSalgsPrisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mSalgsPrisTextBox.Name = "mSalgsPrisTextBox";
            this.mSalgsPrisTextBox.Size = new System.Drawing.Size(183, 34);
            this.mSalgsPrisTextBox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(100, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Salgspris";
            // 
            // mBiDTextBox
            // 
            this.mBiDTextBox.BackColor = System.Drawing.Color.White;
            this.mBiDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBiDTextBox.Location = new System.Drawing.Point(283, 412);
            this.mBiDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mBiDTextBox.Name = "mBiDTextBox";
            this.mBiDTextBox.Size = new System.Drawing.Size(183, 34);
            this.mBiDTextBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Indtast Bolig ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(473, 474);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 29);
            this.label9.TabIndex = 73;
            this.label9.Text = "Kr";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.CbBoligSolgt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.mKøbsDatoTextBox);
            this.panel1.Controls.Add(this.mKøbsPrisTextBox);
            this.panel1.Controls.Add(this.mKøberIDTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(84, 592);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 258);
            this.panel1.TabIndex = 74;
            // 
            // CbBoligSolgt
            // 
            this.CbBoligSolgt.AutoSize = true;
            this.CbBoligSolgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBoligSolgt.Location = new System.Drawing.Point(187, 26);
            this.CbBoligSolgt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbBoligSolgt.Name = "CbBoligSolgt";
            this.CbBoligSolgt.Size = new System.Drawing.Size(222, 33);
            this.CbBoligSolgt.TabIndex = 80;
            this.CbBoligSolgt.Text = "Er Boligen Solgt?";
            this.CbBoligSolgt.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 29);
            this.label8.TabIndex = 81;
            this.label8.Text = "Kr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 84;
            this.label7.Text = "DDMMÅÅÅÅ";
            // 
            // mKøbsDatoTextBox
            // 
            this.mKøbsDatoTextBox.BackColor = System.Drawing.Color.White;
            this.mKøbsDatoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKøbsDatoTextBox.Location = new System.Drawing.Point(187, 185);
            this.mKøbsDatoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mKøbsDatoTextBox.Name = "mKøbsDatoTextBox";
            this.mKøbsDatoTextBox.Size = new System.Drawing.Size(183, 34);
            this.mKøbsDatoTextBox.TabIndex = 83;
            // 
            // mKøbsPrisTextBox
            // 
            this.mKøbsPrisTextBox.BackColor = System.Drawing.Color.White;
            this.mKøbsPrisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKøbsPrisTextBox.Location = new System.Drawing.Point(187, 134);
            this.mKøbsPrisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mKøbsPrisTextBox.Name = "mKøbsPrisTextBox";
            this.mKøbsPrisTextBox.Size = new System.Drawing.Size(183, 34);
            this.mKøbsPrisTextBox.TabIndex = 82;
            // 
            // mKøberIDTextBox
            // 
            this.mKøberIDTextBox.BackColor = System.Drawing.Color.White;
            this.mKøberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKøberIDTextBox.Location = new System.Drawing.Point(187, 78);
            this.mKøberIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mKøberIDTextBox.Name = "mKøberIDTextBox";
            this.mKøberIDTextBox.Size = new System.Drawing.Size(183, 34);
            this.mKøberIDTextBox.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 78;
            this.label6.Text = "Købsdato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 77;
            this.label5.Text = "Købspris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 76;
            this.label4.Text = "Købers ID Nr";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(84, 545);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 50);
            this.panel2.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(311, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 29);
            this.label10.TabIndex = 86;
            this.label10.Text = "NÅR BOLIGEN ER SOLGT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(311, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "ÆNDRING AF SALGSPRIS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(84, 332);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 50);
            this.panel3.TabIndex = 87;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // bolig_StatusTableAdapter
            // 
            this.bolig_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1168, 916);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpdaterBolig);
            this.Controls.Add(this.mSalgsPrisTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mBiDTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateBolig";
            this.Text = "UpdateBolig";
            this.Load += new System.EventHandler(this.UpdateBolig_Load);
            this.tabPageBoliger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageKøber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageBoliger;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKøber;
        private System.Windows.Forms.Button btnOpdaterBolig;
        private System.Windows.Forms.MaskedTextBox mSalgsPrisTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mBiDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mKøbsDatoTextBox;
        private System.Windows.Forms.MaskedTextBox mKøbsPrisTextBox;
        private System.Windows.Forms.MaskedTextBox mKøberIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbBoligSolgt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solgtDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kaspermark_dk_db_realboligDataSet1 kaspermark_dk_db_realboligDataSet1;
        private System.Windows.Forms.BindingSource boligStatusBindingSource;
        private kaspermark_dk_db_realboligDataSet1TableAdapters.Bolig_StatusTableAdapter bolig_StatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsDatoDataGridViewTextBoxColumn;
    }
}