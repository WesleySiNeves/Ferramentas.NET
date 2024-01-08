namespace VerificadorLicencas.NET
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
            txtLocalizacaoArquivoBanco = new TextBox();
            label1 = new Label();
            btnExecutar = new Button();
            SuspendLayout();
            // 
            // txtLocalizacaoArquivoBanco
            // 
            txtLocalizacaoArquivoBanco.Location = new Point(234, 41);
            txtLocalizacaoArquivoBanco.Name = "txtLocalizacaoArquivoBanco";
            txtLocalizacaoArquivoBanco.Size = new Size(803, 27);
            txtLocalizacaoArquivoBanco.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "Localizacao Arquivo Bancos";
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(1062, 40);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(119, 29);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 783);
            Controls.Add(btnExecutar);
            Controls.Add(label1);
            Controls.Add(txtLocalizacaoArquivoBanco);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocalizacaoArquivoBanco;
        private Label label1;
        private Button btnExecutar;
    }
}