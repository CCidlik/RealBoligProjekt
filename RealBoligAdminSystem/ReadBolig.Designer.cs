
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
            this.kaspermark_dk_db_realboligDataSet = new RealBolig.kaspermark_dk_db_realboligDataSet();
            this.boligBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgtDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).BeginInit();
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
            this.btnIndlæsBolig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndlæsBolig.Location = new System.Drawing.Point(167, 139);
            this.btnIndlæsBolig.Name = "btnIndlæsBolig";
            this.btnIndlæsBolig.Size = new System.Drawing.Size(152, 40);
            this.btnIndlæsBolig.TabIndex = 54;
            this.btnIndlæsBolig.Text = "Indlæs Bolig";
            this.btnIndlæsBolig.UseVisualStyleBackColor = true;
            this.btnIndlæsBolig.Click += new System.EventHandler(this.btnIndlæsBolig_Click);
            // 
            // tbOmråde
            // 
            this.tbOmråde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOmråde.Location = new System.Drawing.Point(167, 12);
            this.tbOmråde.Name = "tbOmråde";
            this.tbOmråde.Size = new System.Drawing.Size(330, 29);
            this.tbOmråde.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Indtast område";
            // 
            // Postnummer
            // 
            this.Postnummer.AutoSize = true;
            this.Postnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postnummer.Location = new System.Drawing.Point(12, 70);
            this.Postnummer.Name = "Postnummer";
            this.Postnummer.Size = new System.Drawing.Size(117, 24);
            this.Postnummer.TabIndex = 56;
            this.Postnummer.Text = "Postnummer";
            // 
            // tbPostnummer
            // 
            this.tbPostnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostnummer.Location = new System.Drawing.Point(167, 70);
            this.tbPostnummer.Name = "tbPostnummer";
            this.tbPostnummer.Size = new System.Drawing.Size(138, 29);
            this.tbPostnummer.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(520, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 291);
            this.dataGridView1.TabIndex = 58;
            // 
            // kaspermark_dk_db_realboligDataSet
            // 
            this.kaspermark_dk_db_realboligDataSet.DataSetName = "kaspermark_dk_db_realboligDataSet";
            this.kaspermark_dk_db_realboligDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligBindingSource2
            // 
            this.boligBindingSource2.DataMember = "Bolig";
            this.boligBindingSource2.DataSource = this.kaspermark_dk_db_realboligDataSet;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BiD";
            this.dataGridViewTextBoxColumn1.HeaderText = "BiD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KiD";
            this.dataGridViewTextBoxColumn2.HeaderText = "KiD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PostNR";
            this.dataGridViewTextBoxColumn3.HeaderText = "PostNR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Område";
            this.dataGridViewTextBoxColumn5.HeaderText = "Område";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SalgsPris";
            this.dataGridViewTextBoxColumn6.HeaderText = "SalgsPris";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SalgsDato";
            this.dataGridViewTextBoxColumn7.HeaderText = "SalgsDato";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Kvm";
            this.dataGridViewTextBoxColumn8.HeaderText = "Kvm";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // solgtDataGridViewCheckBoxColumn
            // 
            this.solgtDataGridViewCheckBoxColumn.DataPropertyName = "Solgt";
            this.solgtDataGridViewCheckBoxColumn.HeaderText = "Solgt";
            this.solgtDataGridViewCheckBoxColumn.Name = "solgtDataGridViewCheckBoxColumn";
            // 
            // ReadBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbPostnummer);
            this.Controls.Add(this.Postnummer);
            this.Controls.Add(this.btnIndlæsBolig);
            this.Controls.Add(this.tbOmråde);
            this.Controls.Add(this.label1);
            this.Name = "ReadBolig";
            this.Text = "ReadBolig";
            this.Load += new System.EventHandler(this.ReadBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}