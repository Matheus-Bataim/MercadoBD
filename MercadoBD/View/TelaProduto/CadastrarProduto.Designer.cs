namespace MercadoBD.View.TelaProduto
{
    partial class CadastrarProduto
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
            btn_CadProd = new Button();
            tbx_nomeProd = new TextBox();
            tbx_marcaProd = new TextBox();
            tbx_valProd = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(154, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 45);
            label1.TabIndex = 1;
            label1.Text = "Casdastro do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(264, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(264, 277);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(268, 378);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 4;
            label4.Text = "Valor";
            // 
            // btn_CadProd
            // 
            btn_CadProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CadProd.Location = new Point(203, 507);
            btn_CadProd.Name = "btn_CadProd";
            btn_CadProd.Size = new Size(184, 102);
            btn_CadProd.TabIndex = 5;
            btn_CadProd.Text = "Cadastrar";
            btn_CadProd.UseVisualStyleBackColor = true;
            
            // 
            // tbx_nomeProd
            // 
            tbx_nomeProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_nomeProd.Location = new Point(187, 200);
            tbx_nomeProd.Name = "tbx_nomeProd";
            tbx_nomeProd.Size = new Size(233, 39);
            tbx_nomeProd.TabIndex = 6;
            // 
            // tbx_marcaProd
            // 
            tbx_marcaProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_marcaProd.Location = new Point(187, 312);
            tbx_marcaProd.Name = "tbx_marcaProd";
            tbx_marcaProd.Size = new Size(233, 39);
            tbx_marcaProd.TabIndex = 7;
            // 
            // tbx_valProd
            // 
            tbx_valProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_valProd.Location = new Point(220, 413);
            tbx_valProd.Name = "tbx_valProd";
            tbx_valProd.Size = new Size(150, 39);
            tbx_valProd.TabIndex = 8;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 750);
            Controls.Add(tbx_valProd);
            Controls.Add(tbx_marcaProd);
            Controls.Add(tbx_nomeProd);
            Controls.Add(btn_CadProd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarProduto";
            Text = "CadastrarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_CadProd;
        private TextBox tbx_nomeProd;
        private TextBox tbx_marcaProd;
        private TextBox tbx_valProd;
    }
}