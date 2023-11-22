namespace MercadoBD.View.TelaCliente
{
    partial class CadastroCliente
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
            label3 = new Label();
            label4 = new Label();
            foneArea = new MaskedTextBox();
            btn_CadastrarCli = new Button();
            tbx_NomeCli = new TextBox();
            tbx_EmailCli = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 44);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 0;
            label1.Text = "Casdastro do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 108);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 164);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 227);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // foneArea
            // 
            foneArea.Location = new Point(49, 245);
            foneArea.Mask = "(99) 0000-0000";
            foneArea.Name = "foneArea";
            foneArea.Size = new Size(100, 23);
            foneArea.TabIndex = 7;
            // 
            // btn_CadastrarCli
            // 
            btn_CadastrarCli.Location = new Point(107, 338);
            btn_CadastrarCli.Name = "btn_CadastrarCli";
            btn_CadastrarCli.Size = new Size(206, 77);
            btn_CadastrarCli.TabIndex = 8;
            btn_CadastrarCli.Text = "Cadastrar";
            btn_CadastrarCli.UseVisualStyleBackColor = true;
            btn_CadastrarCli.Click += btn_CadastrarCli_Click;
            // 
            // tbx_NomeCli
            // 
            tbx_NomeCli.Location = new Point(49, 126);
            tbx_NomeCli.Name = "tbx_NomeCli";
            tbx_NomeCli.Size = new Size(202, 23);
            tbx_NomeCli.TabIndex = 9;
            // 
            // tbx_EmailCli
            // 
            tbx_EmailCli.Location = new Point(49, 182);
            tbx_EmailCli.Name = "tbx_EmailCli";
            tbx_EmailCli.Size = new Size(202, 23);
            tbx_EmailCli.TabIndex = 10;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(tbx_EmailCli);
            Controls.Add(tbx_NomeCli);
            Controls.Add(btn_CadastrarCli);
            Controls.Add(foneArea);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox foneArea;
        private Button btn_CadastrarCli;
        private TextBox tbx_NomeCli;
        private TextBox tbx_EmailCli;
    }
}