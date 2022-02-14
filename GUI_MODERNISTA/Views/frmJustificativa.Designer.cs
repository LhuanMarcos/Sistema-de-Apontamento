
namespace GUI_MODERNISTA.Views
{
    partial class frmJustificativa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJustificativa));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchSituation = new System.Windows.Forms.GroupBox();
            this.rbSearchInativ = new System.Windows.Forms.RadioButton();
            this.rsSearch = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgJustification = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchJustification = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCategoria = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBoxSituation = new System.Windows.Forms.GroupBox();
            this.rbStatusInctive = new System.Windows.Forms.RadioButton();
            this.sdStatusActive = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.labelOffice = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBoxSearchSituation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJustification)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxSituation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.groupBoxSearchSituation);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxSearchJustification);
            this.groupBox3.Location = new System.Drawing.Point(184, 217);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(835, 500);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Justificativa";
            // 
            // groupBoxSearchSituation
            // 
            this.groupBoxSearchSituation.Controls.Add(this.rbSearchInativ);
            this.groupBoxSearchSituation.Controls.Add(this.rsSearch);
            this.groupBoxSearchSituation.Location = new System.Drawing.Point(56, 71);
            this.groupBoxSearchSituation.Name = "groupBoxSearchSituation";
            this.groupBoxSearchSituation.Size = new System.Drawing.Size(196, 45);
            this.groupBoxSearchSituation.TabIndex = 101;
            this.groupBoxSearchSituation.TabStop = false;
            this.groupBoxSearchSituation.Text = "Situação";
            // 
            // rbSearchInativ
            // 
            this.rbSearchInativ.AutoSize = true;
            this.rbSearchInativ.Location = new System.Drawing.Point(130, 20);
            this.rbSearchInativ.Name = "rbSearchInativ";
            this.rbSearchInativ.Size = new System.Drawing.Size(61, 19);
            this.rbSearchInativ.TabIndex = 1;
            this.rbSearchInativ.Text = "Inativo";
            this.rbSearchInativ.UseVisualStyleBackColor = true;
            this.rbSearchInativ.CheckedChanged += new System.EventHandler(this.rbSearchInativ_CheckedChanged);
            // 
            // rsSearch
            // 
            this.rsSearch.AutoSize = true;
            this.rsSearch.Checked = true;
            this.rsSearch.Location = new System.Drawing.Point(6, 20);
            this.rsSearch.Name = "rsSearch";
            this.rsSearch.Size = new System.Drawing.Size(53, 19);
            this.rsSearch.TabIndex = 0;
            this.rsSearch.TabStop = true;
            this.rsSearch.Text = "Ativo";
            this.rsSearch.UseVisualStyleBackColor = true;
            this.rsSearch.CheckedChanged += new System.EventHandler(this.rsSearch_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dgJustification);
            this.groupBox2.Location = new System.Drawing.Point(5, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 367);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // dgJustification
            // 
            this.dgJustification.AllowUserToResizeColumns = false;
            this.dgJustification.AllowUserToResizeRows = false;
            this.dgJustification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgJustification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgJustification.BackgroundColor = System.Drawing.Color.White;
            this.dgJustification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgJustification.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgJustification.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJustification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgJustification.ColumnHeadersHeight = 28;
            this.dgJustification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgJustification.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgJustification.EnableHeadersVisualStyles = false;
            this.dgJustification.Location = new System.Drawing.Point(7, 20);
            this.dgJustification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgJustification.Name = "dgJustification";
            this.dgJustification.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJustification.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgJustification.RowHeadersVisible = false;
            this.dgJustification.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgJustification.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgJustification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgJustification.Size = new System.Drawing.Size(811, 341);
            this.dgJustification.TabIndex = 93;
            this.dgJustification.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJustification_CellDoubleClick);
            this.dgJustification.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgJustification_CellFormatting);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.buttonSearch.Enabled = false;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.Location = new System.Drawing.Point(718, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 23);
            this.buttonSearch.TabIndex = 99;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(1530, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1486, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Série:";
            // 
            // textBoxSearchJustification
            // 
            this.textBoxSearchJustification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchJustification.Location = new System.Drawing.Point(55, 43);
            this.textBoxSearchJustification.Name = "textBoxSearchJustification";
            this.textBoxSearchJustification.Size = new System.Drawing.Size(635, 23);
            this.textBoxSearchJustification.TabIndex = 90;
            this.textBoxSearchJustification.TextChanged += new System.EventHandler(this.textBoxSearchJustification_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtCategoria);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.groupBoxSituation);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtJustification);
            this.groupBox1.Controls.Add(this.labelOffice);
            this.groupBox1.Location = new System.Drawing.Point(184, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(835, 156);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Justificativa";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 104;
            this.label2.Text = "Categoria:";
            // 
            // dtCategoria
            // 
            this.dtCategoria.FormattingEnabled = true;
            this.dtCategoria.Location = new System.Drawing.Point(130, 37);
            this.dtCategoria.Name = "dtCategoria";
            this.dtCategoria.Size = new System.Drawing.Size(678, 23);
            this.dtCategoria.TabIndex = 103;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(600, 123);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 23);
            this.btnEdit.TabIndex = 102;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBoxSituation
            // 
            this.groupBoxSituation.Controls.Add(this.rbStatusInctive);
            this.groupBoxSituation.Controls.Add(this.sdStatusActive);
            this.groupBoxSituation.Location = new System.Drawing.Point(57, 101);
            this.groupBoxSituation.Name = "groupBoxSituation";
            this.groupBoxSituation.Size = new System.Drawing.Size(196, 45);
            this.groupBoxSituation.TabIndex = 101;
            this.groupBoxSituation.TabStop = false;
            this.groupBoxSituation.Text = "Situação";
            // 
            // rbStatusInctive
            // 
            this.rbStatusInctive.AutoSize = true;
            this.rbStatusInctive.Enabled = false;
            this.rbStatusInctive.Location = new System.Drawing.Point(130, 20);
            this.rbStatusInctive.Name = "rbStatusInctive";
            this.rbStatusInctive.Size = new System.Drawing.Size(61, 19);
            this.rbStatusInctive.TabIndex = 1;
            this.rbStatusInctive.Text = "Inativo";
            this.rbStatusInctive.UseVisualStyleBackColor = true;
            // 
            // sdStatusActive
            // 
            this.sdStatusActive.AutoSize = true;
            this.sdStatusActive.Checked = true;
            this.sdStatusActive.Enabled = false;
            this.sdStatusActive.Location = new System.Drawing.Point(6, 20);
            this.sdStatusActive.Name = "sdStatusActive";
            this.sdStatusActive.Size = new System.Drawing.Size(53, 19);
            this.sdStatusActive.TabIndex = 0;
            this.sdStatusActive.TabStop = true;
            this.sdStatusActive.Text = "Ativo";
            this.sdStatusActive.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Location = new System.Drawing.Point(709, 123);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 23);
            this.buttonSave.TabIndex = 99;
            this.buttonSave.Text = "Cadastrar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(1530, 386);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 23);
            this.textBox2.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1486, 389);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 20);
            this.label17.TabIndex = 69;
            this.label17.Text = "Série:";
            // 
            // txtJustification
            // 
            this.txtJustification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtJustification.Location = new System.Drawing.Point(130, 66);
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(678, 23);
            this.txtJustification.TabIndex = 90;
            // 
            // labelOffice
            // 
            this.labelOffice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOffice.Location = new System.Drawing.Point(54, 67);
            this.labelOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(75, 21);
            this.labelOffice.TabIndex = 59;
            this.labelOffice.Text = "Justificativa:";
            // 
            // frmJustificativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 746);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmJustificativa";
            this.Text = "frmCadastroRegistroPonto";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSearchSituation.ResumeLayout(false);
            this.groupBoxSearchSituation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgJustification)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSituation.ResumeLayout(false);
            this.groupBoxSituation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxSearchSituation;
        private System.Windows.Forms.RadioButton rbSearchInativ;
        private System.Windows.Forms.RadioButton rsSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgJustification;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchJustification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBoxSituation;
        private System.Windows.Forms.RadioButton rbStatusInctive;
        private System.Windows.Forms.RadioButton sdStatusActive;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dtCategoria;
    }
}