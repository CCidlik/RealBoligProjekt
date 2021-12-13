
namespace RealBolig
{
    partial class DeleteBolig
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
            this.btnSletBolig = new System.Windows.Forms.Button();
            this.mBoligIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelBiD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boligBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet = new RealBolig.kaspermark_dk_db_realboligDataSet();
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boligBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSletBolig
            // 
            this.btnSletBolig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSletBolig.Location = new System.Drawing.Point(698, 65);
            this.btnSletBolig.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSletBolig.Name = "btnSletBolig";
            this.btnSletBolig.Size = new System.Drawing.Size(357, 62);
            this.btnSletBolig.TabIndex = 71;
            this.btnSletBolig.Text = "Slet Bolig";
            this.btnSletBolig.UseVisualStyleBackColor = true;
            this.btnSletBolig.Click += new System.EventHandler(this.btnSletBolig_Click);
            this.btnSletBolig.MouseHover += new System.EventHandler(this.btnSletBolig_MouseHover);
            // 
            // mBoligIDTextBox
            // 
            this.mBoligIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBoligIDTextBox.Location = new System.Drawing.Point(298, 65);
            this.mBoligIDTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mBoligIDTextBox.Name = "mBoligIDTextBox";
            this.mBoligIDTextBox.Size = new System.Drawing.Size(270, 55);
            this.mBoligIDTextBox.TabIndex = 56;
            // 
            // labelBiD
            // 
            this.labelBiD.AutoSize = true;
            this.labelBiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiD.Location = new System.Drawing.Point(74, 65);
            this.labelBiD.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelBiD.Name = "labelBiD";
            this.labelBiD.Size = new System.Drawing.Size(167, 48);
            this.labelBiD.TabIndex = 55;
            this.labelBiD.Text = "Bolig ID";
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.boligBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(147, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1638, 526);
            this.dataGridView1.TabIndex = 72;
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
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Solgt";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Solgt";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // boligBindingSource3
            // 
            this.boligBindingSource3.DataMember = "Bolig";
            this.boligBindingSource3.DataSource = this.kaspermark_dk_db_realboligDataSet;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(147, 604);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 91);
            this.panel1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(726, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SLET BOLIG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.mBoligIDTextBox);
            this.panel2.Controls.Add(this.labelBiD);
            this.panel2.Controls.Add(this.btnSletBolig);
            this.panel2.Location = new System.Drawing.Point(147, 694);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1638, 265);
            this.panel2.TabIndex = 74;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            // 
            // boligBindingSource1
            // 
            this.boligBindingSource1.DataMember = "Bolig";
            // 
            // boligBindingSource2
            // 
            this.boligBindingSource2.DataMember = "Bolig";
            // 
            // DeleteBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(2044, 1660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "DeleteBolig";
            this.Text = "DeleteBolig";
            this.Load += new System.EventHandler(this.DeleteBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource boligBindingSource;
        private System.Windows.Forms.Button btnSletBolig;
        private System.Windows.Forms.MaskedTextBox mBoligIDTextBox;
        private System.Windows.Forms.Label labelBiD;
        //private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource1;
        //private kaspermark_dk_db_realboligDataSet4 kaspermark_dk_db_realboligDataSet4;
        private System.Windows.Forms.BindingSource boligBindingSource2;
        //private kaspermark_dk_db_realboligDataSet4TableAdapters.BoligTableAdapter boligTableAdapter1;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn biDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solgtDataGridViewCheckBoxColumn;*/
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource3;
        private kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}