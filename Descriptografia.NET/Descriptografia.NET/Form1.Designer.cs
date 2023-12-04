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
            rbPermissaoUsuario = new RadioButton();
            label3 = new Label();
            BtnDescriptografar = new Button();
            rbPermissaoGrupo = new RadioButton();
            BtnExportar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 31);
            label1.TabIndex = 0;
            label1.Text = "Cole o texto Criptografado:";
            // 
            // TxtTextoCriptografado
            // 
            TxtTextoCriptografado.Location = new Point(1, 52);
            TxtTextoCriptografado.Name = "TxtTextoCriptografado";
            TxtTextoCriptografado.Size = new Size(748, 800);
            TxtTextoCriptografado.TabIndex = 1;
            TxtTextoCriptografado.Text = "";
            // 
            // txtTextoDescriptografado
            // 
            txtTextoDescriptografado.Location = new Point(990, 52);
            txtTextoDescriptografado.Name = "txtTextoDescriptografado";
            txtTextoDescriptografado.Size = new Size(807, 800);
            txtTextoDescriptografado.TabIndex = 2;
            txtTextoDescriptografado.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(990, 9);
            label2.Name = "label2";
            label2.Size = new Size(258, 31);
            label2.TabIndex = 3;
            label2.Text = "Saída Descriptografada:";
            // 
            // rbPermissaoUsuario
            // 
            rbPermissaoUsuario.AutoSize = true;
            rbPermissaoUsuario.Checked = true;
            rbPermissaoUsuario.Location = new Point(815, 204);
            rbPermissaoUsuario.Name = "rbPermissaoUsuario";
            rbPermissaoUsuario.Size = new Size(150, 24);
            rbPermissaoUsuario.TabIndex = 4;
            rbPermissaoUsuario.TabStop = true;
            rbPermissaoUsuario.Text = "Permissão Usuário";
            rbPermissaoUsuario.UseVisualStyleBackColor = true;
            rbPermissaoUsuario.CheckedChanged += rbPermissaoUsuario_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(810, 137);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 5;
            label3.Text = "Tipo Permissão";
            // 
            // BtnDescriptografar
            // 
            BtnDescriptografar.Location = new Point(822, 319);
            BtnDescriptografar.Name = "BtnDescriptografar";
            BtnDescriptografar.Size = new Size(143, 44);
            BtnDescriptografar.TabIndex = 6;
            BtnDescriptografar.Text = "Descriptografar";
            BtnDescriptografar.UseVisualStyleBackColor = true;
            BtnDescriptografar.Click += BtnDescriptografar_Click;
            // 
            // rbPermissaoGrupo
            // 
            rbPermissaoGrupo.AutoSize = true;
            rbPermissaoGrupo.Location = new Point(824, 260);
            rbPermissaoGrupo.Name = "rbPermissaoGrupo";
            rbPermissaoGrupo.Size = new Size(141, 24);
            rbPermissaoGrupo.TabIndex = 7;
            rbPermissaoGrupo.Text = "Permissão Grupo";
            rbPermissaoGrupo.UseVisualStyleBackColor = true;
            rbPermissaoGrupo.CheckedChanged += rbPermissaoGrupo_CheckedChanged;
            // 
            // BtnExportar
            // 
            BtnExportar.Location = new Point(825, 399);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(143, 44);
            BtnExportar.TabIndex = 8;
            BtnExportar.Text = "Exportar HMTL";
            BtnExportar.UseVisualStyleBackColor = true;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1813, 889);
            Controls.Add(BtnExportar);
            Controls.Add(rbPermissaoGrupo);
            Controls.Add(BtnDescriptografar);
            Controls.Add(label3);
            Controls.Add(rbPermissaoUsuario);
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
        private RadioButton rbPermissaoUsuario;
        private Label label3;
        private Button BtnDescriptografar;
        private RadioButton rbPermissaoGrupo;
        private Button BtnExportar;
    }
}