
namespace RealBolig
{
    partial class CreateKunde
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
            this.btnOpretKunde = new System.Windows.Forms.Button();
            this.kundeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelAdresse = new System.Windows.Forms.Label();
            this.mAdresseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.mMailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTlf = new System.Windows.Forms.Label();
            this.mTlfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelFnavn = new System.Windows.Forms.Label();
            this.mFnavnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermarkdkdbrealboligDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet2 = new RealBolig.kaspermark_dk_db_realboligDataSet2();
            this.kundeTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermarkdkdbrealboligDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpretKunde
            // 
            this.btnOpretKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpretKunde.Location = new System.Drawing.Point(952, 56);
            this.btnOpretKunde.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnOpretKunde.Name = "btnOpretKunde";
            this.btnOpretKunde.Size = new System.Drawing.Size(280, 62);
            this.btnOpretKunde.TabIndex = 19;
            this.btnOpretKunde.Text = "Opret Kunde";
            this.btnOpretKunde.UseVisualStyleBackColor = true;
            this.btnOpretKunde.Click += new System.EventHandler(this.btnOpretKunde_Click);
            this.btnOpretKunde.MouseHover += new System.EventHandler(this.btnOpretKunde_MouseHover);
            // 
            // kundeBindingSource1
            // 
            this.kundeBindingSource1.DataMember = "Kunde";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(203, 908);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(173, 48);
            this.labelAdresse.TabIndex = 17;
            this.labelAdresse.Text = "Adresse";
            // 
            // mAdresseTextBox
            // 
            this.mAdresseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAdresseTextBox.Location = new System.Drawing.Point(523, 897);
            this.mAdresseTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mAdresseTextBox.Name = "mAdresseTextBox";
            this.mAdresseTextBox.Size = new System.Drawing.Size(541, 55);
            this.mAdresseTextBox.TabIndex = 16;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(56, 227);
            this.labelMail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(140, 48);
            this.labelMail.TabIndex = 15;
            this.labelMail.Text = "E-Mail";
            // 
            // mMailTextBox
            // 
            this.mMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMailTextBox.Location = new System.Drawing.Point(523, 819);
            this.mMailTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mMailTextBox.Name = "mMailTextBox";
            this.mMailTextBox.Size = new System.Drawing.Size(541, 55);
            this.mMailTextBox.TabIndex = 14;
            // 
            // labelTlf
            // 
            this.labelTlf.AutoSize = true;
            this.labelTlf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTlf.Location = new System.Drawing.Point(56, 149);
            this.labelTlf.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTlf.Name = "labelTlf";
            this.labelTlf.Size = new System.Drawing.Size(220, 48);
            this.labelTlf.TabIndex = 13;
            this.labelTlf.Text = "Telefon nr.";
            // 
            // mTlfTextBox
            // 
            this.mTlfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTlfTextBox.Location = new System.Drawing.Point(523, 741);
            this.mTlfTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mTlfTextBox.Name = "mTlfTextBox";
            this.mTlfTextBox.Size = new System.Drawing.Size(541, 55);
            this.mTlfTextBox.TabIndex = 12;
            // 
            // labelFnavn
            // 
            this.labelFnavn.AutoSize = true;
            this.labelFnavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelFnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFnavn.Location = new System.Drawing.Point(203, 674);
            this.labelFnavn.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelFnavn.Name = "labelFnavn";
            this.labelFnavn.Size = new System.Drawing.Size(233, 48);
            this.labelFnavn.TabIndex = 11;
            this.labelFnavn.Text = "Fulde Navn";
            // 
            // mFnavnTextBox
            // 
            this.mFnavnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mFnavnTextBox.Location = new System.Drawing.Point(376, 56);
            this.mFnavnTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mFnavnTextBox.Name = "mFnavnTextBox";
            this.mFnavnTextBox.Size = new System.Drawing.Size(541, 55);
            this.mFnavnTextBox.TabIndex = 10;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.kundeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(147, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1493, 446);
            this.dataGridView1.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KiD";
            this.dataGridViewTextBoxColumn1.HeaderText = "KiD";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FuldeNavn";
            this.dataGridViewTextBoxColumn2.HeaderText = "FuldeNavn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tlf";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tlf";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // kundeBindingSource2
            // 
            this.kundeBindingSource2.DataMember = "Kunde";
            this.kundeBindingSource2.DataSource = this.kaspermarkdkdbrealboligDataSet2BindingSource;
            // 
            // kaspermarkdkdbrealboligDataSet2BindingSource
            // 
            this.kaspermarkdkdbrealboligDataSet2BindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet2;
            this.kaspermarkdkdbrealboligDataSet2BindingSource.Position = 0;
            // 
            // kaspermark_dk_db_realboligDataSet2
            // 
            this.kaspermark_dk_db_realboligDataSet2.DataSetName = "kaspermark_dk_db_realboligDataSet2";
            this.kaspermark_dk_db_realboligDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(147, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 78);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(548, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPRET KUNDE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnOpretKunde);
            this.panel2.Controls.Add(this.mFnavnTextBox);
            this.panel2.Controls.Add(this.labelTlf);
            this.panel2.Controls.Add(this.labelMail);
            this.panel2.Location = new System.Drawing.Point(147, 602);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1493, 480);
            this.panel2.TabIndex = 22;
            // 
            // CreateKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(2401, 1276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.mAdresseTextBox);
            this.Controls.Add(this.mMailTextBox);
            this.Controls.Add(this.mTlfTextBox);
            this.Controls.Add(this.labelFnavn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "CreateKunde";
            this.Text = "CreateKunde";
            this.Load += new System.EventHandler(this.CreateKunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermarkdkdbrealboligDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpretKunde;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.MaskedTextBox mAdresseTextBox;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.MaskedTextBox mMailTextBox;
        private System.Windows.Forms.Label labelTlf;
        private System.Windows.Forms.MaskedTextBox mTlfTextBox;
        private System.Windows.Forms.Label labelFnavn;
        private System.Windows.Forms.MaskedTextBox mFnavnTextBox;
        //private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource1;
        //private kaspermark_dk_db_realboligDataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kaspermarkdkdbrealboligDataSet2BindingSource;
        private kaspermark_dk_db_realboligDataSet2 kaspermark_dk_db_realboligDataSet2;
        private System.Windows.Forms.BindingSource kundeBindingSource2;
        private kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}