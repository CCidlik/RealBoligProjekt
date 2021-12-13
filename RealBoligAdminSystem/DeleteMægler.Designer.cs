
namespace RealBolig
{
    partial class DeleteMægler
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
            this.tbAiD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet3 = new RealBolig.kaspermark_dk_db_realboligDataSet3();
            this.ejendomsmæglerTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter();
            this.ejendomsmæglerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AiDdelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAiD
            // 
            this.tbAiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAiD.Location = new System.Drawing.Point(216, 36);
            this.tbAiD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAiD.Name = "tbAiD";
            this.tbAiD.Size = new System.Drawing.Size(100, 28);
            this.tbAiD.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aiDDataGridViewTextBoxColumn,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ejendomsmæglerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 200);
            this.dataGridView1.TabIndex = 4;
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
            // ejendomsmæglerBindingSource
            // 
            this.ejendomsmæglerBindingSource.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet3;
            // 
            // kaspermark_dk_db_realboligDataSet3
            // 
            this.kaspermark_dk_db_realboligDataSet3.DataSetName = "kaspermark_dk_db_realboligDataSet3";
            this.kaspermark_dk_db_realboligDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejendomsmæglerTableAdapter
            // 
            this.ejendomsmæglerTableAdapter.ClearBeforeFill = true;
            // 
            // ejendomsmæglerBindingSource1
            // 
            this.ejendomsmæglerBindingSource1.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Indtast Mægler ID";
            // 
            // AiDdelete
            // 
            this.AiDdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AiDdelete.Location = new System.Drawing.Point(347, 36);
            this.AiDdelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AiDdelete.Name = "AiDdelete";
            this.AiDdelete.Size = new System.Drawing.Size(136, 28);
            this.AiDdelete.TabIndex = 7;
            this.AiDdelete.Text = "Slet Mægler";
            this.AiDdelete.UseVisualStyleBackColor = true;
            this.AiDdelete.Click += new System.EventHandler(this.AiDdelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.tbAiD);
            this.panel1.Controls.Add(this.AiDdelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 270);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 127);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(63, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 35);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SLET MÆGLER";
            // 
            // DeleteMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1029, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteMægler";
            this.Text = "DeleteMægler";
            this.Load += new System.EventHandler(this.DeleteMægler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbAiD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet3 kaspermark_dk_db_realboligDataSet3;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource;
        private kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AiDdelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}