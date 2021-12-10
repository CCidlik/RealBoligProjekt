
namespace RealBolig
{
    partial class CreateMægler
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
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpretMægler = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.mMailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTlf = new System.Windows.Forms.Label();
            this.mTlfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelFnavn = new System.Windows.Forms.Label();
            this.mFnavnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet3 = new RealBolig.kaspermark_dk_db_realboligDataSet3();
            this.ejendomsmæglerTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ejendomsmæglerBindingSource
            // 
            this.ejendomsmæglerBindingSource.DataMember = "Ejendomsmægler";
            // 
            // btnOpretMægler
            // 
            this.btnOpretMægler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpretMægler.Location = new System.Drawing.Point(542, 35);
            this.btnOpretMægler.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpretMægler.Name = "btnOpretMægler";
            this.btnOpretMægler.Size = new System.Drawing.Size(160, 34);
            this.btnOpretMægler.TabIndex = 28;
            this.btnOpretMægler.Text = "Opret Mægler";
            this.btnOpretMægler.UseVisualStyleBackColor = true;
            this.btnOpretMægler.Click += new System.EventHandler(this.btnOpretMægler_Click_1);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(32, 123);
            this.labelMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(82, 29);
            this.labelMail.TabIndex = 25;
            this.labelMail.Text = "E-Mail";
            // 
            // mMailTextBox
            // 
            this.mMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMailTextBox.Location = new System.Drawing.Point(214, 118);
            this.mMailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mMailTextBox.Name = "mMailTextBox";
            this.mMailTextBox.Size = new System.Drawing.Size(311, 34);
            this.mMailTextBox.TabIndex = 24;
            // 
            // labelTlf
            // 
            this.labelTlf.AutoSize = true;
            this.labelTlf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTlf.Location = new System.Drawing.Point(32, 82);
            this.labelTlf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTlf.Name = "labelTlf";
            this.labelTlf.Size = new System.Drawing.Size(129, 29);
            this.labelTlf.TabIndex = 23;
            this.labelTlf.Text = "Telefon nr.";
            // 
            // mTlfTextBox
            // 
            this.mTlfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTlfTextBox.Location = new System.Drawing.Point(214, 77);
            this.mTlfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mTlfTextBox.Name = "mTlfTextBox";
            this.mTlfTextBox.Size = new System.Drawing.Size(311, 34);
            this.mTlfTextBox.TabIndex = 22;
            // 
            // labelFnavn
            // 
            this.labelFnavn.AutoSize = true;
            this.labelFnavn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelFnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFnavn.Location = new System.Drawing.Point(32, 40);
            this.labelFnavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFnavn.Name = "labelFnavn";
            this.labelFnavn.Size = new System.Drawing.Size(136, 29);
            this.labelFnavn.TabIndex = 21;
            this.labelFnavn.Text = "Fulde Navn";
            // 
            // mFnavnTextBox
            // 
            this.mFnavnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mFnavnTextBox.Location = new System.Drawing.Point(214, 35);
            this.mFnavnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mFnavnTextBox.Name = "mFnavnTextBox";
            this.mFnavnTextBox.Size = new System.Drawing.Size(311, 34);
            this.mFnavnTextBox.TabIndex = 20;
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
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.ejendomsmæglerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(84, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(853, 246);
            this.dataGridView1.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AiD";
            this.dataGridViewTextBoxColumn1.HeaderText = "AiD";
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
            // ejendomsmæglerBindingSource1
            // 
            this.ejendomsmæglerBindingSource1.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet3;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.mTlfTextBox);
            this.panel1.Controls.Add(this.mFnavnTextBox);
            this.panel1.Controls.Add(this.btnOpretMægler);
            this.panel1.Controls.Add(this.labelFnavn);
            this.panel1.Controls.Add(this.labelMail);
            this.panel1.Controls.Add(this.labelTlf);
            this.panel1.Controls.Add(this.mMailTextBox);
            this.panel1.Location = new System.Drawing.Point(84, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 182);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(84, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 43);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(350, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "OPRET MÆGLER";
            // 
            // CreateMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1372, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateMægler";
            this.Text = "CreateMægler";
            this.Load += new System.EventHandler(this.CreateMægler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        //private kaspermark_dk_db_realboligDataSet5 kaspermark_dk_db_realboligDataSet5;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource;
        //private kaspermark_dk_db_realboligDataSet5TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn aiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.Button btnOpretMægler;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.MaskedTextBox mMailTextBox;
        private System.Windows.Forms.Label labelTlf;
        private System.Windows.Forms.MaskedTextBox mTlfTextBox;
        private System.Windows.Forms.Label labelFnavn;
        private System.Windows.Forms.MaskedTextBox mFnavnTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_realboligDataSet3 kaspermark_dk_db_realboligDataSet3;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource1;
        private kaspermark_dk_db_realboligDataSet3TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}