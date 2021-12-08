
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
            this.dGVCreateMægler = new System.Windows.Forms.DataGridView();
            this.kaspermark_dk_db_realboligDataSet5 = new RealBolig.kaspermark_dk_db_realboligDataSet5();
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet5TableAdapters.EjendomsmæglerTableAdapter();
            this.aiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpret = new System.Windows.Forms.Button();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.mAdresseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.mMailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTlf = new System.Windows.Forms.Label();
            this.mTlfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelFnavn = new System.Windows.Forms.Label();
            this.mFnavnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCreateMægler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCreateMægler
            // 
            this.dGVCreateMægler.AutoGenerateColumns = false;
            this.dGVCreateMægler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVCreateMægler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCreateMægler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aiDDataGridViewTextBoxColumn,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dGVCreateMægler.DataSource = this.ejendomsmæglerBindingSource;
            this.dGVCreateMægler.Location = new System.Drawing.Point(92, 70);
            this.dGVCreateMægler.Name = "dGVCreateMægler";
            this.dGVCreateMægler.ReadOnly = true;
            this.dGVCreateMægler.RowHeadersWidth = 51;
            this.dGVCreateMægler.RowTemplate.Height = 24;
            this.dGVCreateMægler.Size = new System.Drawing.Size(641, 150);
            this.dGVCreateMægler.TabIndex = 0;
            // 
            // kaspermark_dk_db_realboligDataSet5
            // 
            this.kaspermark_dk_db_realboligDataSet5.DataSetName = "kaspermark_dk_db_realboligDataSet5";
            this.kaspermark_dk_db_realboligDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejendomsmæglerBindingSource
            // 
            this.ejendomsmæglerBindingSource.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet5;
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
            // btnOpret
            // 
            this.btnOpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpret.Location = new System.Drawing.Point(270, 424);
            this.btnOpret.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(203, 49);
            this.btnOpret.TabIndex = 28;
            this.btnOpret.Text = "Opret Kunde";
            this.btnOpret.UseVisualStyleBackColor = true;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(87, 375);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(102, 29);
            this.labelAdresse.TabIndex = 27;
            this.labelAdresse.Text = "Adresse";
            // 
            // mAdresseTextBox
            // 
            this.mAdresseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAdresseTextBox.Location = new System.Drawing.Point(270, 370);
            this.mAdresseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mAdresseTextBox.Name = "mAdresseTextBox";
            this.mAdresseTextBox.Size = new System.Drawing.Size(311, 34);
            this.mAdresseTextBox.TabIndex = 26;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(87, 333);
            this.labelMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(82, 29);
            this.labelMail.TabIndex = 25;
            this.labelMail.Text = "E-Mail";
            // 
            // mMailTextBox
            // 
            this.mMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMailTextBox.Location = new System.Drawing.Point(270, 328);
            this.mMailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mMailTextBox.Name = "mMailTextBox";
            this.mMailTextBox.Size = new System.Drawing.Size(311, 34);
            this.mMailTextBox.TabIndex = 24;
            // 
            // labelTlf
            // 
            this.labelTlf.AutoSize = true;
            this.labelTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTlf.Location = new System.Drawing.Point(87, 291);
            this.labelTlf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTlf.Name = "labelTlf";
            this.labelTlf.Size = new System.Drawing.Size(129, 29);
            this.labelTlf.TabIndex = 23;
            this.labelTlf.Text = "Telefon nr.";
            // 
            // mTlfTextBox
            // 
            this.mTlfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTlfTextBox.Location = new System.Drawing.Point(270, 286);
            this.mTlfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mTlfTextBox.Name = "mTlfTextBox";
            this.mTlfTextBox.Size = new System.Drawing.Size(311, 34);
            this.mTlfTextBox.TabIndex = 22;
            // 
            // labelFnavn
            // 
            this.labelFnavn.AutoSize = true;
            this.labelFnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFnavn.Location = new System.Drawing.Point(87, 249);
            this.labelFnavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFnavn.Name = "labelFnavn";
            this.labelFnavn.Size = new System.Drawing.Size(136, 29);
            this.labelFnavn.TabIndex = 21;
            this.labelFnavn.Text = "Fulde Navn";
            // 
            // mFnavnTextBox
            // 
            this.mFnavnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mFnavnTextBox.Location = new System.Drawing.Point(270, 244);
            this.mFnavnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mFnavnTextBox.Name = "mFnavnTextBox";
            this.mFnavnTextBox.Size = new System.Drawing.Size(311, 34);
            this.mFnavnTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpret);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.mAdresseTextBox);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.mMailTextBox);
            this.Controls.Add(this.labelTlf);
            this.Controls.Add(this.mTlfTextBox);
            this.Controls.Add(this.labelFnavn);
            this.Controls.Add(this.mFnavnTextBox);
            this.Controls.Add(this.dGVCreateMægler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateMægler";
            this.Text = "CreateMægler";
            this.Load += new System.EventHandler(this.CreateMægler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCreateMægler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCreateMægler;
        private kaspermark_dk_db_realboligDataSet5 kaspermark_dk_db_realboligDataSet5;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource;
        private kaspermark_dk_db_realboligDataSet5TableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOpret;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.MaskedTextBox mAdresseTextBox;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.MaskedTextBox mMailTextBox;
        private System.Windows.Forms.Label labelTlf;
        private System.Windows.Forms.MaskedTextBox mTlfTextBox;
        private System.Windows.Forms.Label labelFnavn;
        private System.Windows.Forms.MaskedTextBox mFnavnTextBox;
        private System.Windows.Forms.Button button1;
    }
}