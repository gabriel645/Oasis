namespace Oasis2
{
    partial class Oasis
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
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.btnCadLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.Location = new System.Drawing.Point(58, 60);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(117, 23);
            this.btnCadUsuario.TabIndex = 0;
            this.btnCadUsuario.Text = "Cad Usuário";
            this.btnCadUsuario.UseVisualStyleBackColor = true;
            this.btnCadUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Location = new System.Drawing.Point(58, 89);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(117, 23);
            this.btnCadFunc.TabIndex = 1;
            this.btnCadFunc.Text = "Cad Funcionario";
            this.btnCadFunc.UseVisualStyleBackColor = true;
            // 
            // btnCadLivro
            // 
            this.btnCadLivro.Location = new System.Drawing.Point(58, 118);
            this.btnCadLivro.Name = "btnCadLivro";
            this.btnCadLivro.Size = new System.Drawing.Size(117, 23);
            this.btnCadLivro.TabIndex = 2;
            this.btnCadLivro.Text = "Cad Livro";
            this.btnCadLivro.UseVisualStyleBackColor = true;
            // 
            // Oasis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 515);
            this.Controls.Add(this.btnCadLivro);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.btnCadUsuario);
            this.Name = "Oasis";
            this.Text = "Oasis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Button btnCadLivro;
    }
}

