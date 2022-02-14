
namespace GUI_MODERNISTA.Views
{
    partial class frmLancamentoPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentoPonto));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchInc = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchAct = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchEmployeerReale = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFinalDateReale = new System.Windows.Forms.ComboBox();
            this.labelFinalDateReale = new System.Windows.Forms.Label();
            this.comboBoxStartDateReale = new System.Windows.Forms.ComboBox();
            this.labelStartDateReale = new System.Windows.Forms.Label();
            this.comboBoxPointEmployeerReale = new System.Windows.Forms.ComboBox();
            this.groupBoxSituation = new System.Windows.Forms.GroupBox();
            this.radioButtonSituationInc = new System.Windows.Forms.RadioButton();
            this.radioButtonSituationAct = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPointEmployeerReale = new System.Windows.Forms.TextBox();
            this.labelEmployeerReale = new System.Windows.Forms.Label();
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
            this.groupBox3.Controls.Add(this.textBoxSearchEmployeerReale);
            this.groupBox3.Location = new System.Drawing.Point(182, 170);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(716, 135);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Lançamento Ponto";
            // 
            // groupBoxSearchSituation
            // 
            this.groupBoxSearchSituation.Controls.Add(this.radioButtonSearchInc);
            this.groupBoxSearchSituation.Controls.Add(this.radioButtonSearchAct);
            this.groupBoxSearchSituation.Location = new System.Drawing.Point(56, 71);
            this.groupBoxSearchSituation.Name = "groupBoxSearchSituation";
            this.groupBoxSearchSituation.Size = new System.Drawing.Size(118, 45);
            this.groupBoxSearchSituation.TabIndex = 101;
            this.groupBoxSearchSituation.TabStop = false;
            this.groupBoxSearchSituation.Text = "Situação";
            // 
            // radioButtonSearchInc
            // 
            this.radioButtonSearchInc.AutoSize = true;
            this.radioButtonSearchInc.Location = new System.Drawing.Point(55, 19);
            this.radioButtonSearchInc.Name = "radioButtonSearchInc";
            this.radioButtonSearchInc.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSearchInc.TabIndex = 1;
            this.radioButtonSearchInc.TabStop = true;
            this.radioButtonSearchInc.Text = "Inativo";
            this.radioButtonSearchInc.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchAct
            // 
            this.radioButtonSearchAct.AutoSize = true;
            this.radioButtonSearchAct.Location = new System.Drawing.Point(6, 20);
            this.radioButtonSearchAct.Name = "radioButtonSearchAct";
            this.radioButtonSearchAct.Size = new System.Drawing.Size(49, 17);
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
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.Location = new System.Drawing.Point(576, 42);
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
            this.textBox1.Location = new System.Drawing.Point(1531, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1486, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Série:";
            // 
            // textBoxSearchEmployeerReale
            // 
            this.textBoxSearchEmployeerReale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchEmployeerReale.Location = new System.Drawing.Point(56, 44);
            this.textBoxSearchEmployeerReale.Name = "textBoxSearchEmployeerReale";
            this.textBoxSearchEmployeerReale.Size = new System.Drawing.Size(505, 20);
            this.textBoxSearchEmployeerReale.TabIndex = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(182, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 298);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.comboBoxFinalDateReale);
            this.groupBox1.Controls.Add(this.labelFinalDateReale);
            this.groupBox1.Controls.Add(this.comboBoxStartDateReale);
            this.groupBox1.Controls.Add(this.labelStartDateReale);
            this.groupBox1.Controls.Add(this.comboBoxPointEmployeerReale);
            this.groupBox1.Controls.Add(this.groupBoxSituation);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBoxPointEmployeerReale);
            this.groupBox1.Controls.Add(this.labelEmployeerReale);
            this.groupBox1.Location = new System.Drawing.Point(182, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(716, 135);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lançamento de Ponto";
            // 
            // comboBoxFinalDateReale
            // 
            this.comboBoxFinalDateReale.FormattingEnabled = true;
            this.comboBoxFinalDateReale.Location = new System.Drawing.Point(130, 90);
            this.comboBoxFinalDateReale.Name = "comboBoxFinalDateReale";
            this.comboBoxFinalDateReale.Size = new System.Drawing.Size(122, 21);
            this.comboBoxFinalDateReale.TabIndex = 106;
            // 
            // labelFinalDateReale
            // 
            this.labelFinalDateReale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalDateReale.Location = new System.Drawing.Point(53, 90);
            this.labelFinalDateReale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFinalDateReale.Name = "labelFinalDateReale";
            this.labelFinalDateReale.Size = new System.Drawing.Size(75, 21);
            this.labelFinalDateReale.TabIndex = 105;
            this.labelFinalDateReale.Text = "Data Final:";
            // 
            // comboBoxStartDateReale
            // 
            this.comboBoxStartDateReale.FormattingEnabled = true;
            this.comboBoxStartDateReale.Location = new System.Drawing.Point(130, 63);
            this.comboBoxStartDateReale.Name = "comboBoxStartDateReale";
            this.comboBoxStartDateReale.Size = new System.Drawing.Size(122, 21);
            this.comboBoxStartDateReale.TabIndex = 104;
            // 
            // labelStartDateReale
            // 
            this.labelStartDateReale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDateReale.Location = new System.Drawing.Point(53, 63);
            this.labelStartDateReale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDateReale.Name = "labelStartDateReale";
            this.labelStartDateReale.Size = new System.Drawing.Size(75, 21);
            this.labelStartDateReale.TabIndex = 103;
            this.labelStartDateReale.Text = "Data Inicial:";
            // 
            // comboBoxPointEmployeerReale
            // 
            this.comboBoxPointEmployeerReale.FormattingEnabled = true;
            this.comboBoxPointEmployeerReale.Location = new System.Drawing.Point(269, 37);
            this.comboBoxPointEmployeerReale.Name = "comboBoxPointEmployeerReale";
            this.comboBoxPointEmployeerReale.Size = new System.Drawing.Size(397, 21);
            this.comboBoxPointEmployeerReale.TabIndex = 102;
            // 
            // groupBoxSituation
            // 
            this.groupBoxSituation.Controls.Add(this.radioButtonSituationInc);
            this.groupBoxSituation.Controls.Add(this.radioButtonSituationAct);
            this.groupBoxSituation.Location = new System.Drawing.Point(269, 72);
            this.groupBoxSituation.Name = "groupBoxSituation";
            this.groupBoxSituation.Size = new System.Drawing.Size(128, 44);
            this.groupBoxSituation.TabIndex = 101;
            this.groupBoxSituation.TabStop = false;
            this.groupBoxSituation.Text = "Situação";
            // 
            // radioButtonSituationInc
            // 
            this.radioButtonSituationInc.AutoSize = true;
            this.radioButtonSituationInc.Location = new System.Drawing.Point(61, 19);
            this.radioButtonSituationInc.Name = "radioButtonSituationInc";
            this.radioButtonSituationInc.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSituationInc.TabIndex = 1;
            this.radioButtonSituationInc.TabStop = true;
            this.radioButtonSituationInc.Text = "Inativo";
            this.radioButtonSituationInc.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituationAct
            // 
            this.radioButtonSituationAct.AutoSize = true;
            this.radioButtonSituationAct.Location = new System.Drawing.Point(6, 20);
            this.radioButtonSituationAct.Name = "radioButtonSituationAct";
            this.radioButtonSituationAct.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSituationAct.TabIndex = 0;
            this.radioButtonSituationAct.TabStop = true;
            this.radioButtonSituationAct.Text = "Ativo";
            this.radioButtonSituationAct.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(471, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
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
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Location = new System.Drawing.Point(576, 93);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 23);
            this.buttonSave.TabIndex = 99;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(1531, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1486, 389);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 20);
            this.label17.TabIndex = 69;
            this.label17.Text = "Série:";
            // 
            // textBoxPointEmployeerReale
            // 
            this.textBoxPointEmployeerReale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPointEmployeerReale.Location = new System.Drawing.Point(130, 37);
            this.textBoxPointEmployeerReale.Name = "textBoxPointEmployeerReale";
            this.textBoxPointEmployeerReale.Size = new System.Drawing.Size(122, 20);
            this.textBoxPointEmployeerReale.TabIndex = 90;
            // 
            // labelEmployeerReale
            // 
            this.labelEmployeerReale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeerReale.Location = new System.Drawing.Point(53, 37);
            this.labelEmployeerReale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeerReale.Name = "labelEmployeerReale";
            this.labelEmployeerReale.Size = new System.Drawing.Size(75, 21);
            this.labelEmployeerReale.TabIndex = 59;
            this.labelEmployeerReale.Text = "Funcionário:";
            // 
            // frmCadastroLançamentoPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroLançamentoPonto";
            this.Text = "frmCadastroLançamentoPonto";
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
        private System.Windows.Forms.TextBox textBoxSearchEmployeerReale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFinalDateReale;
        private System.Windows.Forms.Label labelFinalDateReale;
        private System.Windows.Forms.ComboBox comboBoxStartDateReale;
        private System.Windows.Forms.Label labelStartDateReale;
        private System.Windows.Forms.ComboBox comboBoxPointEmployeerReale;
        private System.Windows.Forms.GroupBox groupBoxSituation;
        private System.Windows.Forms.RadioButton radioButtonSituationInc;
        private System.Windows.Forms.RadioButton radioButtonSituationAct;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPointEmployeerReale;
        private System.Windows.Forms.Label labelEmployeerReale;
    }
}