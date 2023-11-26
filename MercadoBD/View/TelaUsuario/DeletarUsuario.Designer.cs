namespace MercadoBD.View.TelaUsuario
{
    partial class DeletarUsuario
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            tip_ = new ComboBox();
            tbx_EmailUser = new TextBox();
            label3 = new Label();
            tbx_NomeCadUser = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 54);
            label1.TabIndex = 0;
            label1.Text = "Excluir Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 1;
            label2.Text = "Digite o código do Usuário:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 154);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(523, 144);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(131, 48);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tip_);
            groupBox1.Controls.Add(tbx_EmailUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_NomeCadUser);
            groupBox1.Location = new Point(50, 202);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(604, 442);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(397, 317);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(177, 100);
            button2.TabIndex = 8;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 249);
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
            label4.Location = new Point(40, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 5;
            label4.Text = "E_mail";
            // 
            // tip_
            // 
            tip_.FormattingEnabled = true;
            tip_.Location = new Point(39, 287);
            tip_.Margin = new Padding(4, 5, 4, 5);
            tip_.Name = "tip_";
            tip_.Size = new Size(171, 33);
            tip_.TabIndex = 4;
            // 
            // tbx_EmailUser
            // 
            tbx_EmailUser.Location = new Point(39, 190);
            tbx_EmailUser.Margin = new Padding(4, 5, 4, 5);
            tbx_EmailUser.Name = "tbx_EmailUser";
            tbx_EmailUser.Size = new Size(363, 31);
            tbx_EmailUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 64);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tbx_NomeCadUser
            // 
            tbx_NomeCadUser.Location = new Point(39, 100);
            tbx_NomeCadUser.Margin = new Padding(4, 5, 4, 5);
            tbx_NomeCadUser.Name = "tbx_NomeCadUser";
            tbx_NomeCadUser.Size = new Size(363, 31);
            tbx_NomeCadUser.TabIndex = 0;
            // 
            // DeletarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 750);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeletarUsuario";
            Text = "Sistema de Gerenciamento de Vendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label5;
        private Label label4;
        private ComboBox tip_;
        private TextBox tbx_EmailUser;
        private Label label3;
        private TextBox tbx_NomeCadUser;
    }
}