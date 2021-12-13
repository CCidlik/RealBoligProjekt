
namespace RealBolig
{
    partial class UpdateMægler
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
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet5 = new RealBolig.kaspermark_dk_db_realboligDataSet5();
            this.ejendomsmæglerTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet5TableAdapters.EjendomsmæglerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEiD = new System.Windows.Forms.TextBox();
            this.tbEfn = new System.Windows.Forms.TextBox();
            this.tbTlf = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.SearchMægler = new System.Windows.Forms.Button();
            this.UpdateInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aiDDataGridViewTextBoxColumn,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ejendomsmæglerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(640, 200);
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
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "Tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "Tlf";
            this.tlfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // ejendomsmæglerBindingSource
            // 
            this.ejendomsmæglerBindingSource.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet5;
            // 
            // kaspermark_dk_db_realboligDataSet5
            // 
            this.kaspermark_dk_db_realboligDataSet5.DataSetName = "kaspermark_dk_db_realboligDataSet5";
            this.kaspermark_dk_db_realboligDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejendomsmæglerTableAdapter
            // 
            this.ejendomsmæglerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mægler ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fulde Navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tlf Nummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // tbEiD
            // 
            this.tbEiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEiD.Location = new System.Drawing.Point(188, 36);
            this.tbEiD.Name = "tbEiD";
            this.tbEiD.Size = new System.Drawing.Size(89, 29);
            this.tbEiD.TabIndex = 5;
            this.tbEiD.TextChanged += new System.EventHandler(this.tbEiD_TextChanged);
            // 
            // tbEfn
            // 
            this.tbEfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEfn.Location = new System.Drawing.Point(251, 379);
            this.tbEfn.Name = "tbEfn";
            this.tbEfn.Size = new System.Drawing.Size(239, 29);
            this.tbEfn.TabIndex = 6;
            // 
            // tbTlf
            // 
            this.tbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTlf.Location = new System.Drawing.Point(188, 143);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(239, 29);
            this.tbTlf.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(251, 448);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(239, 29);
            this.tbEmail.TabIndex = 8;
            // 
            // SearchMægler
            // 
            this.SearchMægler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMægler.Location = new System.Drawing.Point(462, 36);
            this.SearchMægler.Name = "SearchMægler";
            this.SearchMægler.Size = new System.Drawing.Size(115, 29);
            this.SearchMægler.TabIndex = 9;
            this.SearchMægler.Text = "Søg mægler";
            this.SearchMægler.UseVisualStyleBackColor = true;
            this.SearchMægler.Click += new System.EventHandler(this.SearchMægler_Click);
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInfo.Location = new System.Drawing.Point(462, 109);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(115, 63);
            this.UpdateInfo.TabIndex = 10;
            this.UpdateInfo.Text = "Opdater oplysninger";
            this.UpdateInfo.UseVisualStyleBackColor = true;
            this.UpdateInfo.Click += new System.EventHandler(this.UpdateInfo_Click);
            this.UpdateInfo.MouseHover += new System.EventHandler(this.UpdateInfo_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(63, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 35);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(250, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "OPDATER MÆGLER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.tbEiD);
            this.panel2.Controls.Add(this.UpdateInfo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SearchMægler);
            this.panel2.Controls.Add(this.tbTlf);
            this.panel2.Location = new System.Drawing.Point(63, 270);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 226);
            this.panel2.TabIndex = 12;
            // 
            // UpdateMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1029, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbEfn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateMægler";
            this.Text = "UpdateMægler";
            this.Load += new System.EventHandler(this.UpdateMægler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet5 kaspermark_dk_db_realboligDataSet5;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource;
        private kaspermark_dk_db_realboligDataSet5TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEiD;
        private System.Windows.Forms.TextBox tbEfn;
        private System.Windows.Forms.TextBox tbTlf;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button SearchMægler;
        private System.Windows.Forms.Button UpdateInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}