namespace MercadoBD.View.TelaPedido
{
    partial class NF
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
            lbl_Data = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label14 = new Label();
            label4 = new Label();
            lbl_valorTotal = new Label();
            nf_itens = new Label();
            Finalizar_NF = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 31);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 0;
            label1.Text = "Nota Fiscal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 75);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 1;
            label2.Text = "Rua Carlos, 800 - SBC - SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 100);
            label3.Name = "label3";
            label3.Size = new Size(231, 25);
            label3.TabIndex = 2;
            label3.Text = "CNPJ : 15.355.987/0001/00";
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data.Location = new Point(40, 150);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(94, 21);
            lbl_Data.TabIndex = 3;
            lbl_Data.Text = "00/00/0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(216, 150);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 4;
            label5.Text = "1233";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(268, 150);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 5;
            label6.Text = "CCP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(304, 150);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 6;
            label7.Text = "0002";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(356, 150);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 7;
            label8.Text = "COD";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(393, 150);
            label14.Name = "label14";
            label14.Size = new Size(37, 21);
            label14.TabIndex = 13;
            label14.Text = "002";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 441);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "Total: ";
            // 
            // lbl_valorTotal
            // 
            lbl_valorTotal.AutoSize = true;
            lbl_valorTotal.Location = new Point(172, 442);
            lbl_valorTotal.Name = "lbl_valorTotal";
            lbl_valorTotal.Size = new Size(41, 15);
            lbl_valorTotal.TabIndex = 16;
            lbl_valorTotal.Text = "R$0,00";
            // 
            // nf_itens
            // 
            nf_itens.BackColor = SystemColors.ControlDark;
            nf_itens.Location = new Point(31, 189);
            nf_itens.Name = "nf_itens";
            nf_itens.Size = new Size(390, 218);
            nf_itens.TabIndex = 14;
            // 
            // Finalizar_NF
            // 
            Finalizar_NF.Location = new Point(155, 486);
            Finalizar_NF.Name = "Finalizar_NF";
            Finalizar_NF.Size = new Size(75, 23);
            Finalizar_NF.TabIndex = 17;
            Finalizar_NF.Text = "Finalizar";
            Finalizar_NF.UseVisualStyleBackColor = true;
            Finalizar_NF.Click += Finalizar_NF_Click;
            // 
            // NF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 536);
            Controls.Add(Finalizar_NF);
            Controls.Add(lbl_valorTotal);
            Controls.Add(label4);
            Controls.Add(nf_itens);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_Data);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NF";
            Text = "NF";
            Load += NF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_Data;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label14;
        private Label label4;
        private Label lbl_valorTotal;
        private Label nf_itens;
        private Button Finalizar_NF;
    }
}