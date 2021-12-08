
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
            this.kaspermark_dk_db_realboligDataSet3 = new RealBolig.kaspermark_dk_db_realboligDataSet3();
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter();
            this.aiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AiDdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAiD
            // 
            this.tbAiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAiD.Location = new System.Drawing.Point(178, 331);
            this.tbAiD.Name = "tbAiD";
            this.tbAiD.Size = new System.Drawing.Size(205, 34);
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 216);
            this.dataGridView1.TabIndex = 4;
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
            this.ejendomsmæglerBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Indtast AiD";
            // 
            // AiDdelete
            // 
            this.AiDdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AiDdelete.Location = new System.Drawing.Point(424, 312);
            this.AiDdelete.Name = "AiDdelete";
            this.AiDdelete.Size = new System.Drawing.Size(201, 67);
            this.AiDdelete.TabIndex = 7;
            this.AiDdelete.Text = "Slet Mægler";
            this.AiDdelete.UseVisualStyleBackColor = true;
            this.AiDdelete.Click += new System.EventHandler(this.AiDdelete_Click);
            // 
            // DeleteMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AiDdelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbAiD);
            this.Name = "DeleteMægler";
            this.Text = "DeleteMægler";
            this.Load += new System.EventHandler(this.DeleteMægler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}