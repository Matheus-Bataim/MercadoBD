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
            btn_BuscarAltUser = new Button();
            tbx_AltUser = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            tbx_EmailUser = new TextBox();
            label3 = new Label();
            tbx_NomeUser = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 23);
            label2.Name = "label2";
            label2.Size = new Size(246, 45);
            label2.TabIndex = 2;
            label2.Text = "Alterar Usuários";
            // 
            // btn_BuscarAltUser
            // 
            btn_BuscarAltUser.Location = new Point(297, 114);
            btn_BuscarAltUser.Name = "btn_BuscarAltUser";
            btn_BuscarAltUser.Size = new Size(75, 23);
            btn_BuscarAltUser.TabIndex = 0;
            btn_BuscarAltUser.Text = "Buscar";
            btn_BuscarAltUser.UseVisualStyleBackColor = true;
            // 
            // tbx_AltUser
            // 
            tbx_AltUser.Location = new Point(104, 114);
            tbx_AltUser.Name = "tbx_AltUser";
            tbx_AltUser.Size = new Size(152, 23);
            tbx_AltUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 82);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 0;
            label1.Text = "Digite a Matricula do Usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(tbx_EmailUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_NomeUser);
            groupBox1.Location = new Point(37, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 360);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(278, 190);
            button1.Name = "button1";
            button1.Size = new Size(124, 60);
            button1.TabIndex = 8;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 203);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 7;
            label6.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 148);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 90);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 5;
            label4.Text = "E_mail";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // tbx_EmailUser
            // 
            tbx_EmailUser.Location = new Point(27, 114);
            tbx_EmailUser.Name = "tbx_EmailUser";
            tbx_EmailUser.Size = new Size(255, 23);
            tbx_EmailUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 37);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tbx_NomeUser
            // 
            tbx_NomeUser.Location = new Point(27, 60);
            tbx_NomeUser.Name = "tbx_NomeUser";
            tbx_NomeUser.Size = new Size(255, 23);
            tbx_NomeUser.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 277);
            label7.Name = "label7";
            label7.Size = new Size(147, 21);
            label7.TabIndex = 9;
            label7.Text = "Número de Usuário";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 300);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 10;
            // 
            // AlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(494, 570);
            Controls.Add(groupBox1);
            Controls.Add(btn_BuscarAltUser);
            Controls.Add(tbx_AltUser);
            Controls.Add(label1);
            Controls.Add(label2);
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
        private Button btn_BuscarAltUser;
        private TextBox tbx_AltUser;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox tbx_EmailUser;
        private Label label3;
        private TextBox tbx_NomeUser;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label7;
    }
}