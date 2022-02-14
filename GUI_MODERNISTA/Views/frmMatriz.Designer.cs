
namespace GUI_MODERNISTA.Views
{
    partial class frmMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMatriz = new System.Windows.Forms.TextBox();
            this.groupBoxSituation = new System.Windows.Forms.GroupBox();
            this.rdStatusIn = new System.Windows.Forms.RadioButton();
            this.rdStatusAt = new System.Windows.Forms.RadioButton();
            this.buttonVincular = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgHeadOffice = new System.Windows.Forms.DataGridView();
            this.groupBoxsearchSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSituationInt = new System.Windows.Forms.RadioButton();
            this.radioButtonSituationAct = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSerach = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.btnCep = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSituation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeadOffice)).BeginInit();
            this.groupBoxsearchSituation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textMatriz);
            this.groupBox1.Controls.Add(this.groupBoxSituation);
            this.groupBox1.Controls.Add(this.buttonVincular);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(184, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(840, 162);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Matriz / Filial";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(155, 69);
            this.txtCnpj.Mask = "0000/0000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(653, 23);
            this.txtCnpj.TabIndex = 112;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.btnEdit.Location = new System.Drawing.Point(590, 123);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 27);
            this.btnEdit.TabIndex = 111;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 110;
            this.label2.Text = "CMPJ:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 108;
            this.label1.Text = "Matriz:";
            // 
            // textMatriz
            // 
            this.textMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textMatriz.Location = new System.Drawing.Point(156, 40);
            this.textMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textMatriz.Name = "textMatriz";
            this.textMatriz.Size = new System.Drawing.Size(652, 23);
            this.textMatriz.TabIndex = 107;
            // 
            // groupBoxSituation
            // 
            this.groupBoxSituation.Controls.Add(this.rdStatusIn);
            this.groupBoxSituation.Controls.Add(this.rdStatusAt);
            this.groupBoxSituation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSituation.Location = new System.Drawing.Point(156, 98);
            this.groupBoxSituation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSituation.Name = "groupBoxSituation";
            this.groupBoxSituation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSituation.Size = new System.Drawing.Size(135, 52);
            this.groupBoxSituation.TabIndex = 102;
            this.groupBoxSituation.TabStop = false;
            this.groupBoxSituation.Text = "Situação";
            // 
            // rdStatusIn
            // 
            this.rdStatusIn.AutoSize = true;
            this.rdStatusIn.Enabled = false;
            this.rdStatusIn.Location = new System.Drawing.Point(68, 20);
            this.rdStatusIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdStatusIn.Name = "rdStatusIn";
            this.rdStatusIn.Size = new System.Drawing.Size(60, 19);
            this.rdStatusIn.TabIndex = 1;
            this.rdStatusIn.Text = "Inativo";
            this.rdStatusIn.UseVisualStyleBackColor = true;
            // 
            // rdStatusAt
            // 
            this.rdStatusAt.AutoSize = true;
            this.rdStatusAt.Checked = true;
            this.rdStatusAt.Location = new System.Drawing.Point(8, 20);
            this.rdStatusAt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdStatusAt.Name = "rdStatusAt";
            this.rdStatusAt.Size = new System.Drawing.Size(52, 19);
            this.rdStatusAt.TabIndex = 0;
            this.rdStatusAt.TabStop = true;
            this.rdStatusAt.Text = "Ativo";
            this.rdStatusAt.UseVisualStyleBackColor = true;
            // 
            // buttonVincular
            // 
            this.buttonVincular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.buttonVincular.FlatAppearance.BorderSize = 0;
            this.buttonVincular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVincular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVincular.ForeColor = System.Drawing.Color.White;
            this.buttonVincular.Image = ((System.Drawing.Image)(resources.GetObject("buttonVincular.Image")));
            this.buttonVincular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVincular.Location = new System.Drawing.Point(469, 123);
            this.buttonVincular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVincular.Name = "buttonVincular";
            this.buttonVincular.Size = new System.Drawing.Size(113, 27);
            this.buttonVincular.TabIndex = 100;
            this.buttonVincular.Text = "Vincular Filial";
            this.buttonVincular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVincular.UseVisualStyleBackColor = false;
            this.buttonVincular.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.buttonSave.Location = new System.Drawing.Point(703, 123);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 27);
            this.buttonSave.TabIndex = 99;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(1786, 447);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 23);
            this.textBox2.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1734, 449);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 23);
            this.label17.TabIndex = 69;
            this.label17.Text = "Série:";
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
            this.buttonSearch.Location = new System.Drawing.Point(703, 33);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 27);
            this.buttonSearch.TabIndex = 102;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.dgHeadOffice);
            this.groupBox3.Controls.Add(this.groupBoxsearchSituation);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxSerach);
            this.groupBox3.Location = new System.Drawing.Point(184, 352);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(840, 384);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Matriz / Filial";
            // 
            // dgHeadOffice
            // 
            this.dgHeadOffice.AllowUserToResizeColumns = false;
            this.dgHeadOffice.AllowUserToResizeRows = false;
            this.dgHeadOffice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHeadOffice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgHeadOffice.BackgroundColor = System.Drawing.Color.White;
            this.dgHeadOffice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHeadOffice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgHeadOffice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHeadOffice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgHeadOffice.ColumnHeadersHeight = 28;
            this.dgHeadOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHeadOffice.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgHeadOffice.EnableHeadersVisualStyles = false;
            this.dgHeadOffice.Location = new System.Drawing.Point(21, 120);
            this.dgHeadOffice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgHeadOffice.Name = "dgHeadOffice";
            this.dgHeadOffice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHeadOffice.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgHeadOffice.RowHeadersVisible = false;
            this.dgHeadOffice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgHeadOffice.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgHeadOffice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHeadOffice.Size = new System.Drawing.Size(793, 241);
            this.dgHeadOffice.TabIndex = 103;
            this.dgHeadOffice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHeadOffice_CellDoubleClick);
            // 
            // groupBoxsearchSituation
            // 
            this.groupBoxsearchSituation.Controls.Add(this.radioButtonSituationInt);
            this.groupBoxsearchSituation.Controls.Add(this.radioButtonSituationAct);
            this.groupBoxsearchSituation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxsearchSituation.Location = new System.Drawing.Point(28, 62);
            this.groupBoxsearchSituation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxsearchSituation.Name = "groupBoxsearchSituation";
            this.groupBoxsearchSituation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxsearchSituation.Size = new System.Drawing.Size(160, 52);
            this.groupBoxsearchSituation.TabIndex = 102;
            this.groupBoxsearchSituation.TabStop = false;
            this.groupBoxsearchSituation.Text = "Situação";
            // 
            // radioButtonSituationInt
            // 
            this.radioButtonSituationInt.AutoSize = true;
            this.radioButtonSituationInt.Location = new System.Drawing.Point(71, 22);
            this.radioButtonSituationInt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSituationInt.Name = "radioButtonSituationInt";
            this.radioButtonSituationInt.Size = new System.Drawing.Size(60, 19);
            this.radioButtonSituationInt.TabIndex = 1;
            this.radioButtonSituationInt.Text = "Inativo";
            this.radioButtonSituationInt.UseVisualStyleBackColor = true;
            this.radioButtonSituationInt.CheckedChanged += new System.EventHandler(this.radioButtonSituationInt_CheckedChanged);
            // 
            // radioButtonSituationAct
            // 
            this.radioButtonSituationAct.AutoSize = true;
            this.radioButtonSituationAct.Checked = true;
            this.radioButtonSituationAct.Location = new System.Drawing.Point(7, 23);
            this.radioButtonSituationAct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSituationAct.Name = "radioButtonSituationAct";
            this.radioButtonSituationAct.Size = new System.Drawing.Size(52, 19);
            this.radioButtonSituationAct.TabIndex = 0;
            this.radioButtonSituationAct.TabStop = true;
            this.radioButtonSituationAct.Text = "Ativo";
            this.radioButtonSituationAct.UseVisualStyleBackColor = true;
            this.radioButtonSituationAct.CheckedChanged += new System.EventHandler(this.radioButtonSituationAct_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(1786, 447);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1734, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Série:";
            // 
            // textBoxSerach
            // 
            this.textBoxSerach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSerach.Location = new System.Drawing.Point(28, 33);
            this.textBoxSerach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSerach.Name = "textBoxSerach";
            this.textBoxSerach.Size = new System.Drawing.Size(626, 23);
            this.textBoxSerach.TabIndex = 90;
            this.textBoxSerach.TextChanged += new System.EventHandler(this.textBoxSerach_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtUf);
            this.groupBox2.Controls.Add(this.btnCep);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txttNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDistrict);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtComplement);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Location = new System.Drawing.Point(184, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 143);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtUf
            // 
            this.txtUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUf.Location = new System.Drawing.Point(690, 92);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(121, 23);
            this.txtUf.TabIndex = 125;
            // 
            // btnCep
            // 
            this.btnCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.btnCep.FlatAppearance.BorderSize = 0;
            this.btnCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.btnCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCep.ForeColor = System.Drawing.Color.White;
            this.btnCep.Image = ((System.Drawing.Image)(resources.GetObject("btnCep.Image")));
            this.btnCep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCep.Location = new System.Drawing.Point(248, 43);
            this.btnCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(99, 23);
            this.btnCep.TabIndex = 124;
            this.btnCep.Text = "Buscar CEP";
            this.btnCep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCep.UseVisualStyleBackColor = false;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(593, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 19);
            this.label14.TabIndex = 107;
            this.label14.Text = "UF:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(593, 45);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 105;
            this.label15.Text = "Localidade:";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocation.Location = new System.Drawing.Point(690, 43);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(121, 23);
            this.txtLocation.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(248, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 19);
            this.label12.TabIndex = 103;
            this.label12.Text = "Nº";
            // 
            // txttNumber
            // 
            this.txttNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttNumber.Location = new System.Drawing.Point(295, 92);
            this.txttNumber.Name = "txttNumber";
            this.txttNumber.Size = new System.Drawing.Size(52, 23);
            this.txttNumber.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(382, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "Bairro:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDistrict.Location = new System.Drawing.Point(464, 92);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(121, 23);
            this.txtDistrict.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(372, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 99;
            this.label6.Text = "Complemento:";
            // 
            // txtComplement
            // 
            this.txtComplement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplement.Location = new System.Drawing.Point(467, 42);
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(121, 23);
            this.txtComplement.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Logradouro:";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStreet.Location = new System.Drawing.Point(116, 92);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(121, 23);
            this.txtStreet.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 95;
            this.label7.Text = "CEP  :";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.Location = new System.Drawing.Point(116, 42);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(121, 23);
            this.txtCep.TabIndex = 0;
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 746);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMatriz";
            this.Text = "CadastroEmpresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSituation.ResumeLayout(false);
            this.groupBoxSituation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeadOffice)).EndInit();
            this.groupBoxsearchSituation.ResumeLayout(false);
            this.groupBoxsearchSituation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonVincular;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBoxSituation;
        private System.Windows.Forms.RadioButton rdStatusIn;
        private System.Windows.Forms.RadioButton rdStatusAt;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxsearchSituation;
        private System.Windows.Forms.RadioButton radioButtonSituationInt;
        private System.Windows.Forms.RadioButton radioButtonSituationAct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMatriz;
        private System.Windows.Forms.DataGridView dgHeadOffice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCep;
    }
}