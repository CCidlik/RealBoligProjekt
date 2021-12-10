
namespace RealBolig
{
    partial class UpdateKunde
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
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet2 = new RealBolig.kaspermark_dk_db_realboligDataSet2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.kundeTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter();
            this.labelFnavn = new System.Windows.Forms.Label();
            this.mFnavnTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateOplysninger = new System.Windows.Forms.Button();
            this.SearcgKunde = new System.Windows.Forms.Button();
            this.mTlfTextBox = new System.Windows.Forms.TextBox();
            this.mAdresseTextBox = new System.Windows.Forms.TextBox();
            this.mMailTextBox = new System.Windows.Forms.TextBox();
            this.KiDTextBox = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTlf = new System.Windows.Forms.Label();
            this.labelKiD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelKundeOpdateringsDataGridView = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelKundeOpdateringsDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            // 
            // kundeBindingSource1
            // 
            this.kundeBindingSource1.DataMember = "Kunde";
            this.kundeBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet2;
            // 
            // kaspermark_dk_db_realboligDataSet2
            // 
            this.kaspermark_dk_db_realboligDataSet2.DataSetName = "kaspermark_dk_db_realboligDataSet2";
            this.kaspermark_dk_db_realboligDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(63, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 35);
            this.panel3.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(188, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "ÆNDRING AF KUNDEOPLYSNINGER";
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // labelFnavn
            // 
            this.labelFnavn.AutoSize = true;
            this.labelFnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFnavn.Location = new System.Drawing.Point(26, 110);
            this.labelFnavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFnavn.Name = "labelFnavn";
            this.labelFnavn.Size = new System.Drawing.Size(108, 24);
            this.labelFnavn.TabIndex = 90;
            this.labelFnavn.Text = "Fulde Navn";
            // 
            // mFnavnTextBox
            // 
            this.mFnavnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mFnavnTextBox.Location = new System.Drawing.Point(143, 105);
            this.mFnavnTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mFnavnTextBox.Name = "mFnavnTextBox";
            this.mFnavnTextBox.Size = new System.Drawing.Size(234, 28);
            this.mFnavnTextBox.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.updateOplysninger);
            this.panel1.Controls.Add(this.SearcgKunde);
            this.panel1.Controls.Add(this.mTlfTextBox);
            this.panel1.Controls.Add(this.mAdresseTextBox);
            this.panel1.Controls.Add(this.mMailTextBox);
            this.panel1.Controls.Add(this.KiDTextBox);
            this.panel1.Controls.Add(this.labelAdresse);
            this.panel1.Controls.Add(this.labelMail);
            this.panel1.Controls.Add(this.labelTlf);
            this.panel1.Controls.Add(this.labelKiD);
            this.panel1.Controls.Add(this.mFnavnTextBox);
            this.panel1.Controls.Add(this.labelFnavn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(63, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 260);
            this.panel1.TabIndex = 92;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // updateOplysninger
            // 
            this.updateOplysninger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOplysninger.Location = new System.Drawing.Point(409, 105);
            this.updateOplysninger.Margin = new System.Windows.Forms.Padding(1);
            this.updateOplysninger.Name = "updateOplysninger";
            this.updateOplysninger.Size = new System.Drawing.Size(120, 61);
            this.updateOplysninger.TabIndex = 102;
            this.updateOplysninger.Text = "Ret Kunde Oplysninger";
            this.updateOplysninger.UseVisualStyleBackColor = true;
            this.updateOplysninger.Click += new System.EventHandler(this.updateOplysninger_Click);
            // 
            // SearcgKunde
            // 
            this.SearcgKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearcgKunde.Location = new System.Drawing.Point(409, 29);
            this.SearcgKunde.Margin = new System.Windows.Forms.Padding(1);
            this.SearcgKunde.Name = "SearcgKunde";
            this.SearcgKunde.Size = new System.Drawing.Size(120, 28);
            this.SearcgKunde.TabIndex = 101;
            this.SearcgKunde.Text = "Søg kunde";
            this.SearcgKunde.UseVisualStyleBackColor = true;
            this.SearcgKunde.Click += new System.EventHandler(this.SearcgKunde_Click);
            // 
            // mTlfTextBox
            // 
            this.mTlfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTlfTextBox.Location = new System.Drawing.Point(143, 138);
            this.mTlfTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTlfTextBox.Name = "mTlfTextBox";
            this.mTlfTextBox.Size = new System.Drawing.Size(234, 28);
            this.mTlfTextBox.TabIndex = 100;
            // 
            // mAdresseTextBox
            // 
            this.mAdresseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAdresseTextBox.Location = new System.Drawing.Point(143, 203);
            this.mAdresseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mAdresseTextBox.Name = "mAdresseTextBox";
            this.mAdresseTextBox.Size = new System.Drawing.Size(234, 28);
            this.mAdresseTextBox.TabIndex = 99;
            // 
            // mMailTextBox
            // 
            this.mMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMailTextBox.Location = new System.Drawing.Point(143, 170);
            this.mMailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mMailTextBox.Name = "mMailTextBox";
            this.mMailTextBox.Size = new System.Drawing.Size(234, 28);
            this.mMailTextBox.TabIndex = 98;
            // 
            // KiDTextBox
            // 
            this.KiDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KiDTextBox.Location = new System.Drawing.Point(143, 29);
            this.KiDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KiDTextBox.Name = "KiDTextBox";
            this.KiDTextBox.Size = new System.Drawing.Size(234, 28);
            this.KiDTextBox.TabIndex = 96;
            this.KiDTextBox.MouseLeave += new System.EventHandler(this.KiDTextBox_MouseLeave);
            this.KiDTextBox.MouseHover += new System.EventHandler(this.KiDTextBox_MouseHover);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(26, 207);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(80, 24);
            this.labelAdresse.TabIndex = 95;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(26, 174);
            this.labelMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(63, 24);
            this.labelMail.TabIndex = 94;
            this.labelMail.Text = "E-Mail";
            // 
            // labelTlf
            // 
            this.labelTlf.AutoSize = true;
            this.labelTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTlf.Location = new System.Drawing.Point(26, 142);
            this.labelTlf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTlf.Name = "labelTlf";
            this.labelTlf.Size = new System.Drawing.Size(101, 24);
            this.labelTlf.TabIndex = 93;
            this.labelTlf.Text = "Telefon nr.";
            this.labelTlf.Click += new System.EventHandler(this.labelTlf_Click);
            // 
            // labelKiD
            // 
            this.labelKiD.AutoSize = true;
            this.labelKiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKiD.Location = new System.Drawing.Point(26, 33);
            this.labelKiD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKiD.Name = "labelKiD";
            this.labelKiD.Size = new System.Drawing.Size(88, 24);
            this.labelKiD.TabIndex = 92;
            this.labelKiD.Text = "Kunde ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.DataSource = this.kundeBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(640, 200);
            this.dataGridView1.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tlf";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tlf";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panelKundeOpdateringsDataGridView
            // 
            this.panelKundeOpdateringsDataGridView.Controls.Add(this.dataGridView1);
            this.panelKundeOpdateringsDataGridView.Location = new System.Drawing.Point(63, 64);
            this.panelKundeOpdateringsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelKundeOpdateringsDataGridView.Name = "panelKundeOpdateringsDataGridView";
            this.panelKundeOpdateringsDataGridView.Size = new System.Drawing.Size(640, 200);
            this.panelKundeOpdateringsDataGridView.TabIndex = 1;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // UpdateKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1029, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelKundeOpdateringsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateKunde";
            this.Text = "UpdateKunde";
            this.Load += new System.EventHandler(this.UpdateKunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelKundeOpdateringsDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //private kaspermark_dk_db_realboligDataSet1 kaspermark_dk_db_realboligDataSet1;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private kaspermark_dk_db_realboligDataSet2 kaspermark_dk_db_realboligDataSet2;
        private System.Windows.Forms.BindingSource kundeBindingSource1;
        private kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.Label labelFnavn;
        private System.Windows.Forms.TextBox mFnavnTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKiD;
        private System.Windows.Forms.Label labelTlf;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox mAdresseTextBox;
        private System.Windows.Forms.TextBox mMailTextBox;
        private System.Windows.Forms.TextBox KiDTextBox;
        private System.Windows.Forms.TextBox mTlfTextBox;
        private System.Windows.Forms.Button updateOplysninger;
        private System.Windows.Forms.Button SearcgKunde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panelKundeOpdateringsDataGridView;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}