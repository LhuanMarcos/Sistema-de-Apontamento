
namespace GUI_MODERNISTA.Views
{
    partial class frmRelatorioPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioPonto));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchInc = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchAct = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchManager = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSituationInc = new System.Windows.Forms.RadioButton();
            this.radioButtonSituationAct = new System.Windows.Forms.RadioButton();
            this.comboBoxDepartamentManager = new System.Windows.Forms.ComboBox();
            this.comboBoxheadOfficeBranchManager = new System.Windows.Forms.ComboBox();
            this.labelDepartamentManager = new System.Windows.Forms.Label();
            this.labelheadOfficeBranchManager = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.labelNameManager = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBoxSearchSituation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox3.Controls.Add(this.textBoxSearchManager);
            this.groupBox3.Location = new System.Drawing.Point(222, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(835, 156);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Gerente";
            // 
            // groupBoxSearchSituation
            // 
            this.groupBoxSearchSituation.Controls.Add(this.radioButtonSearchInc);
            this.groupBoxSearchSituation.Controls.Add(this.radioButtonSearchAct);
            this.groupBoxSearchSituation.Location = new System.Drawing.Point(65, 82);
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
            // 
            // radioButtonSearchAct
            // 
            this.radioButtonSearchAct.AutoSize = true;
            this.radioButtonSearchAct.Location = new System.Drawing.Point(7, 23);
            this.radioButtonSearchAct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSearchAct.Name = "radioButtonSearchAct";
            this.radioButtonSearchAct.Size = new System.Drawing.Size(53, 19);
            this.radioButtonSearchAct.TabIndex = 0;
            this.radioButtonSearchAct.TabStop = true;
            this.radioButtonSearchAct.Text = "Ativo";
            this.radioButtonSearchAct.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.Location = new System.Drawing.Point(672, 48);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 27);
            this.buttonSearch.TabIndex = 99;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            // textBoxSearchManager
            // 
            this.textBoxSearchManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchManager.Location = new System.Drawing.Point(65, 51);
            this.textBoxSearchManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchManager.Name = "textBoxSearchManager";
            this.textBoxSearchManager.Size = new System.Drawing.Size(588, 23);
            this.textBoxSearchManager.TabIndex = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(222, 381);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(835, 344);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.groupBoxSituation);
            this.groupBox1.Controls.Add(this.comboBoxDepartamentManager);
            this.groupBox1.Controls.Add(this.comboBoxheadOfficeBranchManager);
            this.groupBox1.Controls.Add(this.labelDepartamentManager);
            this.groupBox1.Controls.Add(this.labelheadOfficeBranchManager);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBoxManager);
            this.groupBox1.Controls.Add(this.labelNameManager);
            this.groupBox1.Location = new System.Drawing.Point(222, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(835, 156);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Gerente";
            // 
            // groupBoxSituation
            // 
            this.groupBoxSituation.Controls.Add(this.radioButtonSituationInc);
            this.groupBoxSituation.Controls.Add(this.radioButtonSituationAct);
            this.groupBoxSituation.Location = new System.Drawing.Point(65, 98);
            this.groupBoxSituation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSituation.Name = "groupBoxSituation";
            this.groupBoxSituation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSituation.Size = new System.Drawing.Size(229, 52);
            this.groupBoxSituation.TabIndex = 101;
            this.groupBoxSituation.TabStop = false;
            this.groupBoxSituation.Text = "Situação";
            // 
            // radioButtonSituationInc
            // 
            this.radioButtonSituationInc.AutoSize = true;
            this.radioButtonSituationInc.Enabled = false;
            this.radioButtonSituationInc.Location = new System.Drawing.Point(152, 23);
            this.radioButtonSituationInc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSituationInc.Name = "radioButtonSituationInc";
            this.radioButtonSituationInc.Size = new System.Drawing.Size(61, 19);
            this.radioButtonSituationInc.TabIndex = 1;
            this.radioButtonSituationInc.Text = "Inativo";
            this.radioButtonSituationInc.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituationAct
            // 
            this.radioButtonSituationAct.AutoSize = true;
            this.radioButtonSituationAct.Checked = true;
            this.radioButtonSituationAct.Enabled = false;
            this.radioButtonSituationAct.Location = new System.Drawing.Point(7, 23);
            this.radioButtonSituationAct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSituationAct.Name = "radioButtonSituationAct";
            this.radioButtonSituationAct.Size = new System.Drawing.Size(53, 19);
            this.radioButtonSituationAct.TabIndex = 0;
            this.radioButtonSituationAct.TabStop = true;
            this.radioButtonSituationAct.Text = "Ativo";
            this.radioButtonSituationAct.UseVisualStyleBackColor = true;
            // 
            // comboBoxDepartamentManager
            // 
            this.comboBoxDepartamentManager.FormattingEnabled = true;
            this.comboBoxDepartamentManager.Location = new System.Drawing.Point(527, 60);
            this.comboBoxDepartamentManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDepartamentManager.Name = "comboBoxDepartamentManager";
            this.comboBoxDepartamentManager.Size = new System.Drawing.Size(249, 23);
            this.comboBoxDepartamentManager.TabIndex = 106;
            // 
            // comboBoxheadOfficeBranchManager
            // 
            this.comboBoxheadOfficeBranchManager.FormattingEnabled = true;
            this.comboBoxheadOfficeBranchManager.Location = new System.Drawing.Point(152, 60);
            this.comboBoxheadOfficeBranchManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxheadOfficeBranchManager.Name = "comboBoxheadOfficeBranchManager";
            this.comboBoxheadOfficeBranchManager.Size = new System.Drawing.Size(249, 23);
            this.comboBoxheadOfficeBranchManager.TabIndex = 104;
            // 
            // labelDepartamentManager
            // 
            this.labelDepartamentManager.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDepartamentManager.Location = new System.Drawing.Point(416, 60);
            this.labelDepartamentManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepartamentManager.Name = "labelDepartamentManager";
            this.labelDepartamentManager.Size = new System.Drawing.Size(105, 24);
            this.labelDepartamentManager.TabIndex = 103;
            this.labelDepartamentManager.Text = "Departamento:";
            // 
            // labelheadOfficeBranchManager
            // 
            this.labelheadOfficeBranchManager.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelheadOfficeBranchManager.Location = new System.Drawing.Point(62, 62);
            this.labelheadOfficeBranchManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelheadOfficeBranchManager.Name = "labelheadOfficeBranchManager";
            this.labelheadOfficeBranchManager.Size = new System.Drawing.Size(88, 24);
            this.labelheadOfficeBranchManager.TabIndex = 101;
            this.labelheadOfficeBranchManager.Text = "Matriz/Filial:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(550, 123);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 27);
            this.buttonCancel.TabIndex = 100;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.UseVisualStyleBackColor = false;
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
            this.buttonSave.Location = new System.Drawing.Point(672, 123);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 27);
            this.buttonSave.TabIndex = 99;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
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
            // textBoxManager
            // 
            this.textBoxManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxManager.Location = new System.Drawing.Point(152, 32);
            this.textBoxManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.Size = new System.Drawing.Size(625, 23);
            this.textBoxManager.TabIndex = 90;
            // 
            // labelNameManager
            // 
            this.labelNameManager.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameManager.Location = new System.Drawing.Point(62, 35);
            this.labelNameManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameManager.Name = "labelNameManager";
            this.labelNameManager.Size = new System.Drawing.Size(88, 24);
            this.labelNameManager.TabIndex = 59;
            this.labelNameManager.Text = "Nome:";
            // 
            // frmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 782);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGerente";
            this.Text = "Form2";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSearchSituation.ResumeLayout(false);
            this.groupBoxSearchSituation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButtonSearchAct;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSituation;
        private System.Windows.Forms.RadioButton radioButtonSituationInc;
        private System.Windows.Forms.RadioButton radioButtonSituationAct;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Label labelNameManager;
        private System.Windows.Forms.ComboBox comboBoxDepartamentManager;
        private System.Windows.Forms.ComboBox comboBoxheadOfficeBranchManager;
        private System.Windows.Forms.Label labelDepartamentManager;
        private System.Windows.Forms.Label labelheadOfficeBranchManager;
    }
}