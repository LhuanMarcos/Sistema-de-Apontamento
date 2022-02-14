
namespace GUI_PONTO.Views
{
    partial class frmFilial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBoFilial = new System.Windows.Forms.ComboBox();
            this.labelHeadOffice = new System.Windows.Forms.Label();
            this.cbHeadOffice = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelBranchHeadOffice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbBoFilial);
            this.groupBox1.Controls.Add(this.labelHeadOffice);
            this.groupBox1.Controls.Add(this.cbHeadOffice);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.labelBranchHeadOffice);
            this.groupBox1.Location = new System.Drawing.Point(35, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(820, 171);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Matriz / Filial";
            // 
            // cbBoFilial
            // 
            this.cbBoFilial.FormattingEnabled = true;
            this.cbBoFilial.Location = new System.Drawing.Point(144, 65);
            this.cbBoFilial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBoFilial.Name = "cbBoFilial";
            this.cbBoFilial.Size = new System.Drawing.Size(621, 23);
            this.cbBoFilial.TabIndex = 106;
            // 
            // labelHeadOffice
            // 
            this.labelHeadOffice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeadOffice.Location = new System.Drawing.Point(40, 38);
            this.labelHeadOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeadOffice.Name = "labelHeadOffice";
            this.labelHeadOffice.Size = new System.Drawing.Size(98, 24);
            this.labelHeadOffice.TabIndex = 103;
            this.labelHeadOffice.Text = "Matriz - Filial:";
            // 
            // cbHeadOffice
            // 
            this.cbHeadOffice.FormattingEnabled = true;
            this.cbHeadOffice.Location = new System.Drawing.Point(144, 36);
            this.cbHeadOffice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbHeadOffice.Name = "cbHeadOffice";
            this.cbHeadOffice.Size = new System.Drawing.Size(621, 23);
            this.cbHeadOffice.TabIndex = 102;
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
            this.buttonSave.Location = new System.Drawing.Point(660, 112);
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
            this.textBox2.Location = new System.Drawing.Point(1785, 446);
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
            // labelBranchHeadOffice
            // 
            this.labelBranchHeadOffice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBranchHeadOffice.Location = new System.Drawing.Point(40, 69);
            this.labelBranchHeadOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBranchHeadOffice.Name = "labelBranchHeadOffice";
            this.labelBranchHeadOffice.Size = new System.Drawing.Size(98, 24);
            this.labelBranchHeadOffice.TabIndex = 59;
            this.labelBranchHeadOffice.Text = "Matriz/Filial:";
            // 
            // frmFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 252);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFilial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBoFilial;
        private System.Windows.Forms.Label labelHeadOffice;
        private System.Windows.Forms.ComboBox cbHeadOffice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelBranchHeadOffice;
    }
}