namespace WindowsFormsApp1
{
    partial class FrmProfessor
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
            this.buttonFECHAR = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefonePro = new System.Windows.Forms.TextBox();
            this.txtEmailPro = new System.Windows.Forms.TextBox();
            this.txtCpfPro = new System.Windows.Forms.TextBox();
            this.txtNomePro = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttaoALTERAR = new System.Windows.Forms.Button();
            this.buttonBUSCARID = new System.Windows.Forms.Button();
            this.buttonFECHAR1 = new System.Windows.Forms.Button();
            this.txtIdPro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefonePro1 = new System.Windows.Forms.TextBox();
            this.txtEmailPro1 = new System.Windows.Forms.TextBox();
            this.txtNomePro1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonFECHAR2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 267);
            this.tabControl1.TabIndex = 116;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.buttonFECHAR);
            this.tabPage1.Controls.Add(this.buttonADD);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtTelefonePro);
            this.tabPage1.Controls.Add(this.txtEmailPro);
            this.tabPage1.Controls.Add(this.txtCpfPro);
            this.tabPage1.Controls.Add(this.txtNomePro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFECHAR
            // 
            this.buttonFECHAR.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.buttonADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonADD.Location = new System.Drawing.Point(381, 87);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 126;
            this.buttonADD.Text = "Adicionar";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "Email";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 121;
            this.label10.Text = "CPF";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Nome";
            // 
            // txtTelefonePro
            // 
            this.txtTelefonePro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonePro.Location = new System.Drawing.Point(234, 142);
            this.txtTelefonePro.Name = "txtTelefonePro";
            this.txtTelefonePro.Size = new System.Drawing.Size(121, 20);
            this.txtTelefonePro.TabIndex = 118;
            // 
            // txtEmailPro
            // 
            this.txtEmailPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPro.Location = new System.Drawing.Point(234, 116);
            this.txtEmailPro.Name = "txtEmailPro";
            this.txtEmailPro.Size = new System.Drawing.Size(121, 20);
            this.txtEmailPro.TabIndex = 117;
            // 
            // txtCpfPro
            // 
            this.txtCpfPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpfPro.Location = new System.Drawing.Point(234, 87);
            this.txtCpfPro.Name = "txtCpfPro";
            this.txtCpfPro.Size = new System.Drawing.Size(121, 20);
            this.txtCpfPro.TabIndex = 116;
            // 
            // txtNomePro
            // 
            this.txtNomePro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomePro.Location = new System.Drawing.Point(234, 61);
            this.txtNomePro.Name = "txtNomePro";
            this.txtNomePro.Size = new System.Drawing.Size(121, 20);
            this.txtNomePro.TabIndex = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttaoALTERAR);
            this.tabPage3.Controls.Add(this.buttonBUSCARID);
            this.tabPage3.Controls.Add(this.buttonFECHAR1);
            this.tabPage3.Controls.Add(this.txtIdPro);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtTelefonePro1);
            this.tabPage3.Controls.Add(this.txtEmailPro1);
            this.tabPage3.Controls.Add(this.txtNomePro1);
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
            this.buttaoALTERAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttaoALTERAR.Location = new System.Drawing.Point(387, 96);
            this.buttaoALTERAR.Name = "buttaoALTERAR";
            this.buttaoALTERAR.Size = new System.Drawing.Size(75, 23);
            this.buttaoALTERAR.TabIndex = 135;
            this.buttaoALTERAR.Text = "Alterar";
            this.buttaoALTERAR.UseVisualStyleBackColor = true;
            this.buttaoALTERAR.Click += new System.EventHandler(this.buttaoALTERAR_Click);
            // 
            // buttonBUSCARID
            // 
            this.buttonBUSCARID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBUSCARID.Location = new System.Drawing.Point(308, 61);
            this.buttonBUSCARID.Name = "buttonBUSCARID";
            this.buttonBUSCARID.Size = new System.Drawing.Size(60, 19);
            this.buttonBUSCARID.TabIndex = 133;
            this.buttonBUSCARID.Text = "...";
            this.buttonBUSCARID.UseVisualStyleBackColor = true;
            this.buttonBUSCARID.Click += new System.EventHandler(this.buttonBUSCARID_Click);
            // 
            // buttonFECHAR1
            // 
            this.buttonFECHAR1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFECHAR1.Location = new System.Drawing.Point(387, 128);
            this.buttonFECHAR1.Name = "buttonFECHAR1";
            this.buttonFECHAR1.Size = new System.Drawing.Size(75, 23);
            this.buttonFECHAR1.TabIndex = 132;
            this.buttonFECHAR1.Text = "Fechar";
            this.buttonFECHAR1.UseVisualStyleBackColor = true;
            this.buttonFECHAR1.Click += new System.EventHandler(this.buttonFECHAR1_Click);
            // 
            // txtIdPro
            // 
            this.txtIdPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdPro.Location = new System.Drawing.Point(237, 61);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.ReadOnly = true;
            this.txtIdPro.Size = new System.Drawing.Size(55, 20);
            this.txtIdPro.TabIndex = 129;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "ID";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 124;
            this.label12.Text = "Telefone";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 123;
            this.label13.Text = "Email";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(196, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 120;
            this.label16.Text = "Nome";
            // 
            // txtTelefonePro1
            // 
            this.txtTelefonePro1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonePro1.Location = new System.Drawing.Point(237, 139);
            this.txtTelefonePro1.Name = "txtTelefonePro1";
            this.txtTelefonePro1.Size = new System.Drawing.Size(131, 20);
            this.txtTelefonePro1.TabIndex = 118;
            // 
            // txtEmailPro1
            // 
            this.txtEmailPro1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPro1.Location = new System.Drawing.Point(237, 113);
            this.txtEmailPro1.Name = "txtEmailPro1";
            this.txtEmailPro1.Size = new System.Drawing.Size(131, 20);
            this.txtEmailPro1.TabIndex = 117;
            // 
            // txtNomePro1
            // 
            this.txtNomePro1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomePro1.Location = new System.Drawing.Point(237, 87);
            this.txtNomePro1.Name = "txtNomePro1";
            this.txtNomePro1.Size = new System.Drawing.Size(131, 20);
            this.txtNomePro1.TabIndex = 126;
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
            this.buttonFECHAR2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 173);
            this.listBox1.TabIndex = 103;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Location = new System.Drawing.Point(19, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(474, 23);
            this.button9.TabIndex = 102;
            this.button9.Text = "Listar Todos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 263);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfessor";
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
        private System.Windows.Forms.Button buttonFECHAR;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefonePro;
        private System.Windows.Forms.TextBox txtEmailPro;
        private System.Windows.Forms.TextBox txtCpfPro;
        private System.Windows.Forms.TextBox txtNomePro;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttaoALTERAR;
        private System.Windows.Forms.Button buttonBUSCARID;
        private System.Windows.Forms.Button buttonFECHAR1;
        private System.Windows.Forms.TextBox txtIdPro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelefonePro1;
        private System.Windows.Forms.TextBox txtEmailPro1;
        private System.Windows.Forms.TextBox txtNomePro1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonFECHAR2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button9;
    }
}