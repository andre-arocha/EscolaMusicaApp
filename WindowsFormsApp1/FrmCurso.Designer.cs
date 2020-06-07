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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.cmbNomeCurso = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 25);
            this.button5.TabIndex = 131;
            this.button5.Text = "Fechar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 130;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Carga Horaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 136;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(102, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(128, 20);
            this.txtValor.TabIndex = 137;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(102, 71);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(128, 20);
            this.txtHorario.TabIndex = 138;
            // 
            // cmbNomeCurso
            // 
            this.cmbNomeCurso.FormattingEnabled = true;
            this.cmbNomeCurso.Items.AddRange(new object[] {
            "Violão",
            "Guitarra",
            "Baixo",
            "Bateria",
            "Canto"});
            this.cmbNomeCurso.Location = new System.Drawing.Point(102, 47);
            this.cmbNomeCurso.Name = "cmbNomeCurso";
            this.cmbNomeCurso.Size = new System.Drawing.Size(128, 21);
            this.cmbNomeCurso.TabIndex = 139;
            this.cmbNomeCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(80, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(16, 13);
            this.txtId.TabIndex = 140;
            this.txtId.Text = "Id";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(102, 19);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.ReadOnly = true;
            this.txtIdCurso.Size = new System.Drawing.Size(62, 20);
            this.txtIdCurso.TabIndex = 141;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 142;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 213);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbNomeCurso);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.ComboBox cmbNomeCurso;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Button button3;
    }
}