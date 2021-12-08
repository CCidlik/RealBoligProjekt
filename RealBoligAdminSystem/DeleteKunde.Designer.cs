
namespace RealBolig
{
    partial class DeleteKunde
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKiD = new System.Windows.Forms.TextBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteKiD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kaspermark_dk_db_realboligDataSet2 = new RealBolig.kaspermark_dk_db_realboligDataSet2();
            this.kundeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast KiD";
            // 
            // tbKiD
            // 
            this.tbKiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKiD.Location = new System.Drawing.Point(177, 51);
            this.tbKiD.Name = "tbKiD";
            this.tbKiD.Size = new System.Drawing.Size(155, 29);
            this.tbKiD.TabIndex = 1;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            // 
            // deleteKiD
            // 
            this.deleteKiD.Location = new System.Drawing.Point(381, 51);
            this.deleteKiD.Name = "deleteKiD";
            this.deleteKiD.Size = new System.Drawing.Size(192, 42);
            this.deleteKiD.TabIndex = 3;
            this.deleteKiD.Text = "Slet Kunde";
            this.deleteKiD.UseVisualStyleBackColor = true;
            this.deleteKiD.Click += new System.EventHandler(this.deleteKiD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.kundeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(62, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(661, 265);
            this.dataGridView1.TabIndex = 4;
            // 
            // kaspermark_dk_db_realboligDataSet2
            // 
            this.kaspermark_dk_db_realboligDataSet2.DataSetName = "kaspermark_dk_db_realboligDataSet2";
            this.kaspermark_dk_db_realboligDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeBindingSource1
            // 
            this.kundeBindingSource1.DataMember = "Kunde";
            this.kundeBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet2;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KiD";
            this.dataGridViewTextBoxColumn1.HeaderText = "KiD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FuldeNavn";
            this.dataGridViewTextBoxColumn2.HeaderText = "FuldeNavn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tlf";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tlf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DeleteKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteKiD);
            this.Controls.Add(this.tbKiD);
            this.Controls.Add(this.label1);
            this.Name = "DeleteKunde";
            this.Text = "DeleteKunde";
            this.Load += new System.EventHandler(this.DeleteKunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKiD;
        //private kaspermark_dk_db_realboligDataSet3 kaspermark_dk_db_realboligDataSet3;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        //private kaspermark_dk_db_realboligDataSet3TableAdapters.KundeTableAdapter kundeTableAdapter;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.Button deleteKiD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet2 kaspermark_dk_db_realboligDataSet2;
        private System.Windows.Forms.BindingSource kundeBindingSource1;
        private kaspermark_dk_db_realboligDataSet2TableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}