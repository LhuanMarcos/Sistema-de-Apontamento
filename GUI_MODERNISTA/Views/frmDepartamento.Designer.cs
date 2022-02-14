
namespace GUI_MODERNISTA.Views
{
    partial class frmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchInc = new System.Windows.Forms.RadioButton();
            this.btnSearchChecked = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchOffice = new System.Windows.Forms.TextBox();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBranchOffice = new System.Windows.Forms.ComboBox();
            this.comboBoxHeadOffice = new System.Windows.Forms.ComboBox();
            this.txtDepartamentt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSituationInc = new System.Windows.Forms.RadioButton();
            this.radioButtonSituationAct = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelOffice = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBoxSearchSituation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSituation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.groupBoxSearchSituation);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxSearchOffice);
            this.groupBox3.Location = new System.Drawing.Point(184, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(835, 156);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Departamento";
            // 
            // groupBoxSearchSituation
            // 
            this.groupBoxSearchSituation.Controls.Add(this.radioButtonSearchInc);
            this.groupBoxSearchSituation.Controls.Add(this.btnSearchChecked);
            this.groupBoxSearchSituation.Location = new System.Drawing.Point(78, 81);
            this.groupBoxSearchSituation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchSituation.Name = "groupBoxSearchSituation";
            this.groupBoxSearchSituation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchSituation.Size = new System.Drawing.Size(229, 52);
            this.groupBoxSearchSituation.TabIndex = 101;
            this.groupBoxSearchSituation.TabStop = false;
            this.groupBoxSearchSituation.Text = "Situação";
            // 
            // radioButtonSearchInc
            // 
            this.radioButtonSearchInc.AutoSize = true;
            this.radioButtonSearchInc.Location = new System.Drawing.Point(152, 23);
            this.radioButtonSearchInc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSearchInc.Name = "radioButtonSearchInc";
            this.radioButtonSearchInc.Size = new System.Drawing.Size(61, 19);
            this.radioButtonSearchInc.TabIndex = 1;
            this.radioButtonSearchInc.TabStop = true;
            this.radioButtonSearchInc.Text = "Inativo";
            this.radioButtonSearchInc.UseVisualStyleBackColor = true;
            this.radioButtonSearchInc.CheckedChanged += new System.EventHandler(this.radioButtonSearchInc_CheckedChanged);
            // 
            // btnSearchChecked
            // 
            this.btnSearchChecked.AutoSize = true;
            this.btnSearchChecked.Location = new System.Drawing.Point(7, 23);
            this.btnSearchChecked.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchChecked.Name = "btnSearchChecked";
            this.btnSearchChecked.Size = new System.Drawing.Size(53, 19);
            this.btnSearchChecked.TabIndex = 0;
            this.btnSearchChecked.TabStop = true;
            this.btnSearchChecked.Text = "Ativo";
            this.btnSearchChecked.UseVisualStyleBackColor = true;
            this.btnSearchChecked.CheckedChanged += new System.EventHandler(this.btnSearchChecked_CheckedChanged);
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
            this.buttonSearch.Location = new System.Drawing.Point(702, 48);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 27);
            this.buttonSearch.TabIndex = 99;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1734, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Série:";
            // 
            // textBoxSearchOffice
            // 
            this.textBoxSearchOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchOffice.Location = new System.Drawing.Point(78, 51);
            this.textBoxSearchOffice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchOffice.Name = "textBoxSearchOffice";
            this.textBoxSearchOffice.Size = new System.Drawing.Size(588, 23);
            this.textBoxSearchOffice.TabIndex = 90;
            this.textBoxSearchOffice.TextChanged += new System.EventHandler(this.TextBoxSearchOffice_TextChanged);
            // 
            // dgDepartment
            // 
            this.dgDepartment.AllowUserToResizeColumns = false;
            this.dgDepartment.AllowUserToResizeRows = false;
            this.dgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepartment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDepartment.BackgroundColor = System.Drawing.Color.White;
            this.dgDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDepartment.ColumnHeadersHeight = 28;
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDepartment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDepartment.EnableHeadersVisualStyles = false;
            this.dgDepartment.Location = new System.Drawing.Point(8, 22);
            this.dgDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDepartment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDepartment.RowHeadersVisible = false;
            this.dgDepartment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgDepartment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartment.Size = new System.Drawing.Size(819, 309);
            this.dgDepartment.TabIndex = 93;
            this.dgDepartment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartment_CellDoubleClick);
            this.dgDepartment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDepartment_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dgDepartment);
            this.groupBox2.Location = new System.Drawing.Point(184, 381);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(835, 344);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbBranchOffice);
            this.groupBox1.Controls.Add(this.comboBoxHeadOffice);
            this.groupBox1.Controls.Add(this.txtDepartamentt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBoxSituation);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.labelOffice);
            this.groupBox1.Location = new System.Drawing.Point(184, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(835, 156);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Departamento";
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
            this.btnEdit.Location = new System.Drawing.Point(562, 110);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 27);
            this.btnEdit.TabIndex = 109;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 108;
            this.label3.Text = "Filial:";
            // 
            // cbBranchOffice
            // 
            this.cbBranchOffice.FormattingEnabled = true;
            this.cbBranchOffice.Location = new System.Drawing.Point(135, 113);
            this.cbBranchOffice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBranchOffice.Name = "cbBranchOffice";
            this.cbBranchOffice.Size = new System.Drawing.Size(419, 23);
            this.cbBranchOffice.TabIndex = 107;
            // 
            // comboBoxHeadOffice
            // 
            this.comboBoxHeadOffice.FormattingEnabled = true;
            this.comboBoxHeadOffice.Location = new System.Drawing.Point(135, 67);
            this.comboBoxHeadOffice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxHeadOffice.Name = "comboBoxHeadOffice";
            this.comboBoxHeadOffice.Size = new System.Drawing.Size(419, 23);
            this.comboBoxHeadOffice.TabIndex = 106;
            // 
            // txtDepartamentt
            // 
            this.txtDepartamentt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDepartamentt.Location = new System.Drawing.Point(135, 21);
            this.txtDepartamentt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDepartamentt.Name = "txtDepartamentt";
            this.txtDepartamentt.Size = new System.Drawing.Size(419, 23);
            this.txtDepartamentt.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "Matriz:";
            // 
            // groupBoxSituation
            // 
            this.groupBoxSituation.Controls.Add(this.radioButtonSituationInc);
            this.groupBoxSituation.Controls.Add(this.radioButtonSituationAct);
            this.groupBoxSituation.Location = new System.Drawing.Point(562, 20);
            this.groupBoxSituation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSituation.Name = "groupBoxSituation";
            this.groupBoxSituation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSituation.Size = new System.Drawing.Size(245, 70);
            this.groupBoxSituation.TabIndex = 101;
            this.groupBoxSituation.TabStop = false;
            this.groupBoxSituation.Text = "Situação";
            // 
            // radioButtonSituationInc
            // 
            this.radioButtonSituationInc.AutoSize = true;
            this.radioButtonSituationInc.Location = new System.Drawing.Point(148, 33);
            this.radioButtonSituationInc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSituationInc.Name = "radioButtonSituationInc";
            this.radioButtonSituationInc.Size = new System.Drawing.Size(61, 19);
            this.radioButtonSituationInc.TabIndex = 1;
            this.radioButtonSituationInc.TabStop = true;
            this.radioButtonSituationInc.Text = "Inativo";
            this.radioButtonSituationInc.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituationAct
            // 
            this.radioButtonSituationAct.AutoSize = true;
            this.radioButtonSituationAct.Location = new System.Drawing.Point(7, 33);
            this.radioButtonSituationAct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSituationAct.Name = "radioButtonSituationAct";
            this.radioButtonSituationAct.Size = new System.Drawing.Size(53, 19);
            this.radioButtonSituationAct.TabIndex = 0;
            this.radioButtonSituationAct.TabStop = true;
            this.radioButtonSituationAct.Text = "Ativo";
            this.radioButtonSituationAct.UseVisualStyleBackColor = true;
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
            this.buttonSave.Location = new System.Drawing.Point(702, 110);
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
            // labelOffice
            // 
            this.labelOffice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOffice.Location = new System.Drawing.Point(23, 20);
            this.labelOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(110, 24);
            this.labelOffice.TabIndex = 59;
            this.labelOffice.Text = "Departamento:";
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 746);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDepartamento";
            this.Text = "frmCadastroDepartamento";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSearchSituation.ResumeLayout(false);
            this.groupBoxSearchSituation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSituation.ResumeLayout(false);
            this.groupBoxSituation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxSearchSituation;
        private System.Windows.Forms.RadioButton radioButtonSearchInc;
        private System.Windows.Forms.RadioButton btnSearchChecked;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchOffice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSituation;
        private System.Windows.Forms.RadioButton radioButtonSituationInc;
        private System.Windows.Forms.RadioButton radioButtonSituationAct;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.TextBox txtDepartamentt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHeadOffice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBranchOffice;
        private System.Windows.Forms.DataGridView dgDepartment;
        private System.Windows.Forms.Button btnEdit;
    }
}