namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            button1 = new Button();
            btnConsultar = new Button();
            txtLocalizar = new TextBox();
            lstContatos = new ListView();
            btnAtualuzar = new Button();
            label4 = new Label();
            txtID = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 76);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(118, 11);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(68, 62);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 76);
            button1.Name = "button1";
            button1.Size = new Size(68, 64);
            button1.TabIndex = 7;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(589, 11);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(207, 11);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(376, 23);
            txtLocalizar.TabIndex = 9;
            // 
            // lstContatos
            // 
            lstContatos.Location = new Point(207, 40);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(457, 160);
            lstContatos.TabIndex = 10;
            lstContatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAtualuzar
            // 
            btnAtualuzar.Location = new Point(58, 178);
            btnAtualuzar.Name = "btnAtualuzar";
            btnAtualuzar.Size = new Size(61, 23);
            btnAtualuzar.TabIndex = 11;
            btnAtualuzar.Text = "Atualizar";
            btnAtualuzar.UseVisualStyleBackColor = true;
            btnAtualuzar.Click += btnAtualuzar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 12;
            label4.Text = "ID (para atualizar informações)";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 178);
            txtID.Name = "txtID";
            txtID.Size = new Size(40, 23);
            txtID.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(123, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Apagar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 210);
            Controls.Add(btnDelete);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(btnAtualuzar);
            Controls.Add(lstContatos);
            Controls.Add(txtLocalizar);
            Controls.Add(btnConsultar);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnSalvar;
        private Button button1;
        private Button btnConsultar;
        private TextBox txtLocalizar;
        private ListView lstContatos;
        private Button btnAtualuzar;
        private Label label4;
        private TextBox txtID;
        private Button btnDelete;
    }
}
