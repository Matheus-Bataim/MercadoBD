namespace MercadoBD.View.TelaUsuario
{
    partial class AlterarUsuario
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            btn_AltUser = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cbx_TipoAltUser = new ComboBox();
            tbx_SenhaAltUser = new TextBox();
            tbx_EmailAltUser = new TextBox();
            label3 = new Label();
            tbx_NomeAltUser = new TextBox();
            btn_AltBuscarUser = new Button();
            label1 = new Label();
            tbx_AltBuscarUser = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(149, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 65);
            label2.TabIndex = 2;
            label2.Text = "Alterar Usuários";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_AltUser);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbx_TipoAltUser);
            groupBox1.Controls.Add(tbx_SenhaAltUser);
            groupBox1.Controls.Add(tbx_EmailAltUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_NomeAltUser);
            groupBox1.Location = new Point(53, 270);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(604, 600);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // btn_AltUser
            // 
            btn_AltUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AltUser.Location = new Point(397, 317);
            btn_AltUser.Margin = new Padding(4, 5, 4, 5);
            btn_AltUser.Name = "btn_AltUser";
            btn_AltUser.Size = new Size(177, 100);
            btn_AltUser.TabIndex = 8;
            btn_AltUser.Text = "Alterar";
            btn_AltUser.UseVisualStyleBackColor = true;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 338);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 7;
            label6.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 247);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 5;
            label4.Text = "E_mail";
            // 
            // cbx_TipoAltUser
            // 
            cbx_TipoAltUser.Enabled = false;
            cbx_TipoAltUser.FormattingEnabled = true;
            cbx_TipoAltUser.Location = new Point(39, 287);
            cbx_TipoAltUser.Margin = new Padding(4, 5, 4, 5);
            cbx_TipoAltUser.Name = "cbx_TipoAltUser";
            cbx_TipoAltUser.Size = new Size(171, 33);
            cbx_TipoAltUser.TabIndex = 4;
            // 
            // tbx_SenhaAltUser
            // 
            tbx_SenhaAltUser.Location = new Point(39, 378);
            tbx_SenhaAltUser.Margin = new Padding(4, 5, 4, 5);
            tbx_SenhaAltUser.Name = "tbx_SenhaAltUser";
            tbx_SenhaAltUser.Size = new Size(141, 31);
            tbx_SenhaAltUser.TabIndex = 3;
            // 
            // tbx_EmailAltUser
            // 
            tbx_EmailAltUser.Location = new Point(39, 190);
            tbx_EmailAltUser.Margin = new Padding(4, 5, 4, 5);
            tbx_EmailAltUser.Name = "tbx_EmailAltUser";
            tbx_EmailAltUser.Size = new Size(363, 31);
            tbx_EmailAltUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tbx_NomeAltUser
            // 
            tbx_NomeAltUser.Location = new Point(39, 100);
            tbx_NomeAltUser.Margin = new Padding(4, 5, 4, 5);
            tbx_NomeAltUser.Name = "tbx_NomeAltUser";
            tbx_NomeAltUser.Size = new Size(363, 31);
            tbx_NomeAltUser.TabIndex = 0;
            // 
            // btn_AltBuscarUser
            // 
            btn_AltBuscarUser.Location = new Point(467, 145);
            btn_AltBuscarUser.Name = "btn_AltBuscarUser";
            btn_AltBuscarUser.Size = new Size(112, 34);
            btn_AltBuscarUser.TabIndex = 19;
            btn_AltBuscarUser.Text = "Buscar";
            btn_AltBuscarUser.UseVisualStyleBackColor = true;
            btn_AltBuscarUser.Click += btn_AltBuscarUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 145);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 18;
            label1.Text = "Digite a Matrícula do Usuário";
            // 
            // tbx_AltBuscarUser
            // 
            tbx_AltBuscarUser.Location = new Point(302, 145);
            tbx_AltBuscarUser.Name = "tbx_AltBuscarUser";
            tbx_AltBuscarUser.Size = new Size(121, 31);
            tbx_AltBuscarUser.TabIndex = 17;
            // 
            // AlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(706, 950);
            Controls.Add(btn_AltBuscarUser);
            Controls.Add(label1);
            Controls.Add(tbx_AltBuscarUser);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlterarUsuario";
            Text = "AlterarUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private TextBox tbx_SenhaAltUser;
        private TextBox tbx_EmailAltUser;
        private Label label3;
        private TextBox tbx_NomeAltUser;
        private Button btn_AltUser;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cbx_TipoAltUser;
        private Button btn_AltBuscarUser;
        private Label label1;
        private TextBox tbx_AltBuscarUser;
    }
}