namespace WindowsFormsApp1
{
    partial class FrmCurso
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbNomeCurso = new System.Windows.Forms.ComboBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFECHAR = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttaoALTERAR = new System.Windows.Forms.Button();
            this.buttonBUSCARID = new System.Windows.Forms.Button();
            this.buttonFECHAR1 = new System.Windows.Forms.Button();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonFECHAR2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.cmbNomeCurso1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 267);
            this.tabControl1.TabIndex = 145;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.cmbNomeCurso);
            this.tabPage1.Controls.Add(this.txtHorario);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonFECHAR);
            this.tabPage1.Controls.Add(this.buttonADD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbNomeCurso
            // 
            this.cmbNomeCurso.FormattingEnabled = true;
            this.cmbNomeCurso.Items.AddRange(new object[] {
            "Violão",
            "Guitarra",
            "Baixo",
            "Bateria",
            "Teclado",
            "Canto"});
            this.cmbNomeCurso.Location = new System.Drawing.Point(234, 82);
            this.cmbNomeCurso.Name = "cmbNomeCurso";
            this.cmbNomeCurso.Size = new System.Drawing.Size(128, 21);
            this.cmbNomeCurso.TabIndex = 145;
            this.cmbNomeCurso.SelectedIndexChanged += new System.EventHandler(this.cmbNomeCurso_SelectedIndexChanged);
            // 
            // txtHorario
            // 
            this.txtHorario.Cursor = System.Windows.Forms.Cursors.No;
            this.txtHorario.Location = new System.Drawing.Point(234, 109);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(128, 20);
            this.txtHorario.TabIndex = 144;
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValor.Location = new System.Drawing.Point(234, 136);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(128, 20);
            this.txtValor.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 142;
            this.label3.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Carga Horaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Nome";
            // 
            // buttonFECHAR
            // 
            this.buttonFECHAR.Location = new System.Drawing.Point(381, 126);
            this.buttonFECHAR.Name = "buttonFECHAR";
            this.buttonFECHAR.Size = new System.Drawing.Size(75, 23);
            this.buttonFECHAR.TabIndex = 128;
            this.buttonFECHAR.Text = "Fechar";
            this.buttonFECHAR.UseVisualStyleBackColor = true;
            this.buttonFECHAR.Click += new System.EventHandler(this.buttonFECHAR_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(381, 87);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 126;
            this.buttonADD.Text = "Adicionar";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbNomeCurso1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttaoALTERAR);
            this.tabPage3.Controls.Add(this.buttonBUSCARID);
            this.tabPage3.Controls.Add(this.buttonFECHAR1);
            this.tabPage3.Controls.Add(this.txtIdCurso);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtValor1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(696, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alterar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttaoALTERAR
            // 
            this.buttaoALTERAR.Location = new System.Drawing.Point(394, 75);
            this.buttaoALTERAR.Name = "buttaoALTERAR";
            this.buttaoALTERAR.Size = new System.Drawing.Size(75, 23);
            this.buttaoALTERAR.TabIndex = 135;
            this.buttaoALTERAR.Text = "Alterar";
            this.buttaoALTERAR.UseVisualStyleBackColor = true;
            this.buttaoALTERAR.Click += new System.EventHandler(this.buttaoALTERAR_Click);
            // 
            // buttonBUSCARID
            // 
            this.buttonBUSCARID.Location = new System.Drawing.Point(315, 47);
            this.buttonBUSCARID.Name = "buttonBUSCARID";
            this.buttonBUSCARID.Size = new System.Drawing.Size(60, 19);
            this.buttonBUSCARID.TabIndex = 133;
            this.buttonBUSCARID.Text = "...";
            this.buttonBUSCARID.UseVisualStyleBackColor = true;
            this.buttonBUSCARID.Click += new System.EventHandler(this.buttonBUSCARID_Click);
            // 
            // buttonFECHAR1
            // 
            this.buttonFECHAR1.Location = new System.Drawing.Point(394, 109);
            this.buttonFECHAR1.Name = "buttonFECHAR1";
            this.buttonFECHAR1.Size = new System.Drawing.Size(75, 23);
            this.buttonFECHAR1.TabIndex = 132;
            this.buttonFECHAR1.Text = "Fechar";
            this.buttonFECHAR1.UseVisualStyleBackColor = true;
            this.buttonFECHAR1.Click += new System.EventHandler(this.buttonFECHAR1_Click);
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(244, 47);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.ReadOnly = true;
            this.txtIdCurso.Size = new System.Drawing.Size(55, 20);
            this.txtIdCurso.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 124;
            this.label12.Text = "Valor";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(244, 109);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(131, 20);
            this.txtValor1.TabIndex = 118;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonFECHAR2);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(696, 241);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listar Todos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonFECHAR2
            // 
            this.buttonFECHAR2.Location = new System.Drawing.Point(554, 104);
            this.buttonFECHAR2.Name = "buttonFECHAR2";
            this.buttonFECHAR2.Size = new System.Drawing.Size(75, 23);
            this.buttonFECHAR2.TabIndex = 104;
            this.buttonFECHAR2.Text = "Fechar";
            this.buttonFECHAR2.UseVisualStyleBackColor = true;
            this.buttonFECHAR2.Click += new System.EventHandler(this.buttonFECHAR2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 173);
            this.listBox1.TabIndex = 103;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(19, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(474, 23);
            this.button9.TabIndex = 102;
            this.button9.Text = "Listar Todos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // cmbNomeCurso1
            // 
            this.cmbNomeCurso1.FormattingEnabled = true;
            this.cmbNomeCurso1.Items.AddRange(new object[] {
            "Violão",
            "Guitarra",
            "Baixo",
            "Bateria",
            "Teclado",
            "Canto"});
            this.cmbNomeCurso1.Location = new System.Drawing.Point(244, 82);
            this.cmbNomeCurso1.Name = "cmbNomeCurso1";
            this.cmbNomeCurso1.Size = new System.Drawing.Size(131, 21);
            this.cmbNomeCurso1.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Nome";
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 266);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCurso";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbNomeCurso;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFECHAR;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttaoALTERAR;
        private System.Windows.Forms.Button buttonBUSCARID;
        private System.Windows.Forms.Button buttonFECHAR1;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonFECHAR2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox cmbNomeCurso1;
        private System.Windows.Forms.Label label5;
    }
}