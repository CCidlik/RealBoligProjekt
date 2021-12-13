
namespace RealBolig
{
    partial class ReadMægler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet4 = new RealBolig.kaspermark_dk_db_realboligDataSet4();
            this.kaspermark_dk_db_realboligDataSet3 = new RealBolig.kaspermark_dk_db_realboligDataSet3();
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter();
            this.SearchMægler = new System.Windows.Forms.Button();
            this.kaspermark_dk_db_realboligDataSet1 = new RealBolig.kaspermark_dk_db_realboligDataSet1();
            this.boligStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolig_StatusTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet1TableAdapters.Bolig_StatusTableAdapter();
            this.ejendomsmæglerTableAdapter1 = new RealBolig.kaspermark_dk_db_realboligDataSet4TableAdapters.EjendomsmæglerTableAdapter();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMiD = new System.Windows.Forms.TextBox();
            this.tbTlf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligStatusBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aiDDataGridViewTextBoxColumn,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ejendomsmæglerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(84, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(853, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // aiDDataGridViewTextBoxColumn
            // 
            this.aiDDataGridViewTextBoxColumn.DataPropertyName = "AiD";
            this.aiDDataGridViewTextBoxColumn.HeaderText = "AiD";
            this.aiDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aiDDataGridViewTextBoxColumn.Name = "aiDDataGridViewTextBoxColumn";
            this.aiDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuldeNavnDataGridViewTextBoxColumn
            // 
            this.fuldeNavnDataGridViewTextBoxColumn.DataPropertyName = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.HeaderText = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuldeNavnDataGridViewTextBoxColumn.Name = "fuldeNavnDataGridViewTextBoxColumn";
            this.fuldeNavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "Tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "Tlf";
            this.tlfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            this.tlfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ejendomsmæglerBindingSource1
            // 
            this.ejendomsmæglerBindingSource1.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet4;
            // 
            // kaspermark_dk_db_realboligDataSet4
            // 
            this.kaspermark_dk_db_realboligDataSet4.DataSetName = "kaspermark_dk_db_realboligDataSet4";
            this.kaspermark_dk_db_realboligDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kaspermark_dk_db_realboligDataSet3
            // 
            this.kaspermark_dk_db_realboligDataSet3.DataSetName = "kaspermark_dk_db_realboligDataSet3";
            this.kaspermark_dk_db_realboligDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejendomsmæglerBindingSource
            // 
            this.ejendomsmæglerBindingSource.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet3;
            // 
            // ejendomsmæglerTableAdapter
            // 
            this.ejendomsmæglerTableAdapter.ClearBeforeFill = true;
            // 
            // SearchMægler
            // 
            this.SearchMægler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMægler.Location = new System.Drawing.Point(483, 43);
            this.SearchMægler.Margin = new System.Windows.Forms.Padding(4);
            this.SearchMægler.Name = "SearchMægler";
            this.SearchMægler.Size = new System.Drawing.Size(157, 34);
            this.SearchMægler.TabIndex = 1;
            this.SearchMægler.Text = "Søg Mægler";
            this.SearchMægler.UseVisualStyleBackColor = true;
            this.SearchMægler.Click += new System.EventHandler(this.SearchMægler_Click);
            this.SearchMægler.MouseHover += new System.EventHandler(this.SearchMægler_MouseHover);
            // 
            // kaspermark_dk_db_realboligDataSet1
            // 
            this.kaspermark_dk_db_realboligDataSet1.DataSetName = "kaspermark_dk_db_realboligDataSet1";
            this.kaspermark_dk_db_realboligDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligStatusBindingSource
            // 
            this.boligStatusBindingSource.DataMember = "Bolig_Status";
            this.boligStatusBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet1;
            // 
            // bolig_StatusTableAdapter
            // 
            this.bolig_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // ejendomsmæglerTableAdapter1
            // 
            this.ejendomsmæglerTableAdapter1.ClearBeforeFill = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(648, 43);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(186, 34);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Nulstil Søgning";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mægler ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tlf Nummer";
            // 
            // tbMiD
            // 
            this.tbMiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiD.Location = new System.Drawing.Point(302, 375);
            this.tbMiD.Margin = new System.Windows.Forms.Padding(4);
            this.tbMiD.Name = "tbMiD";
            this.tbMiD.Size = new System.Drawing.Size(132, 34);
            this.tbMiD.TabIndex = 5;
            // 
            // tbTlf
            // 
            this.tbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTlf.Location = new System.Drawing.Point(218, 107);
            this.tbTlf.Margin = new System.Windows.Forms.Padding(4);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(249, 34);
            this.tbTlf.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.tbTlf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchMægler);
            this.panel1.Location = new System.Drawing.Point(84, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 196);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(84, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 43);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(351, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "SØG MÆGLER";
            // 
            // ReadMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1372, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbMiD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReadMægler";
            this.Text = "ReadMægler";
            this.Load += new System.EventHandler(this.ReadMægler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligStatusBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet3 kaspermark_dk_db_realboligDataSet3;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource;
        private kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        private System.Windows.Forms.Button SearchMægler;
        private kaspermark_dk_db_realboligDataSet1 kaspermark_dk_db_realboligDataSet1;
        private System.Windows.Forms.BindingSource boligStatusBindingSource;
        private kaspermark_dk_db_realboligDataSet1TableAdapters.Bolig_StatusTableAdapter bolig_StatusTableAdapter;
        private kaspermark_dk_db_realboligDataSet4 kaspermark_dk_db_realboligDataSet4;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource1;
        private kaspermark_dk_db_realboligDataSet4TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiD;
        private System.Windows.Forms.TextBox tbTlf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}