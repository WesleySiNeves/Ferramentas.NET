namespace Descriptografia.NET
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
            TxtTextoCriptografado = new RichTextBox();
            txtTextoDescriptografado = new RichTextBox();
            label2 = new Label();
            BtnDescriptografar = new Button();
            BtnExportar = new Button();
            txtDiretorioNavegador = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 83);
            label1.Name = "label1";
            label1.Size = new Size(290, 31);
            label1.TabIndex = 0;
            label1.Text = "Cole o texto Criptografado:";
            // 
            // TxtTextoCriptografado
            // 
            TxtTextoCriptografado.Location = new Point(1, 117);
            TxtTextoCriptografado.Name = "TxtTextoCriptografado";
            TxtTextoCriptografado.Size = new Size(748, 735);
            TxtTextoCriptografado.TabIndex = 1;
            TxtTextoCriptografado.Text = "";
            // 
            // txtTextoDescriptografado
            // 
            txtTextoDescriptografado.Location = new Point(943, 117);
            txtTextoDescriptografado.Name = "txtTextoDescriptografado";
            txtTextoDescriptografado.Size = new Size(854, 735);
            txtTextoDescriptografado.TabIndex = 2;
            txtTextoDescriptografado.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(943, 83);
            label2.Name = "label2";
            label2.Size = new Size(258, 31);
            label2.TabIndex = 3;
            label2.Text = "Saída Descriptografada:";
            // 
            // BtnDescriptografar
            // 
            BtnDescriptografar.Location = new Point(782, 321);
            BtnDescriptografar.Name = "BtnDescriptografar";
            BtnDescriptografar.Size = new Size(143, 44);
            BtnDescriptografar.TabIndex = 6;
            BtnDescriptografar.Text = "Descriptografar";
            BtnDescriptografar.UseVisualStyleBackColor = true;
            BtnDescriptografar.Click += BtnDescriptografar_Click;
            // 
            // BtnExportar
            // 
            BtnExportar.Location = new Point(782, 400);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(143, 44);
            BtnExportar.TabIndex = 8;
            BtnExportar.Text = "Exportar HMTL";
            BtnExportar.UseVisualStyleBackColor = true;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // txtDiretorioNavegador
            // 
            txtDiretorioNavegador.Location = new Point(210, 25);
            txtDiretorioNavegador.Name = "txtDiretorioNavegador";
            txtDiretorioNavegador.Size = new Size(539, 27);
            txtDiretorioNavegador.TabIndex = 9;
            txtDiretorioNavegador.Text = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 32);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 10;
            label3.Text = "Diretorio do Navegador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1813, 889);
            Controls.Add(label3);
            Controls.Add(txtDiretorioNavegador);
            Controls.Add(BtnExportar);
            Controls.Add(BtnDescriptografar);
            Controls.Add(label2);
            Controls.Add(txtTextoDescriptografado);
            Controls.Add(TxtTextoCriptografado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox TxtTextoCriptografado;
        private RichTextBox txtTextoDescriptografado;
        private Label label2;
        private Button BtnDescriptografar;
        private Button BtnExportar;
        private TextBox txtDiretorioNavegador;
        private Label label3;
    }
}