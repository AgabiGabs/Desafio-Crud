namespace Empresa.UI.Windows
{
    partial class ProdutoIncluir
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
            this.Idlabel1 = new System.Windows.Forms.Label();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.Nomelabel2 = new System.Windows.Forms.Label();
            this.NometextBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Idlabel1
            // 
            this.Idlabel1.AutoSize = true;
            this.Idlabel1.Location = new System.Drawing.Point(25, 51);
            this.Idlabel1.Name = "Idlabel1";
            this.Idlabel1.Size = new System.Drawing.Size(16, 13);
            this.Idlabel1.TabIndex = 0;
            this.Idlabel1.Text = "Id";
            this.Idlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.Location = new System.Drawing.Point(68, 48);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.Size = new System.Drawing.Size(30, 20);
            this.IdtextBox1.TabIndex = 1;
            // 
            // Nomelabel2
            // 
            this.Nomelabel2.AutoSize = true;
            this.Nomelabel2.Location = new System.Drawing.Point(25, 85);
            this.Nomelabel2.Name = "Nomelabel2";
            this.Nomelabel2.Size = new System.Drawing.Size(35, 13);
            this.Nomelabel2.TabIndex = 2;
            this.Nomelabel2.Text = "Nome";
            // 
            // NometextBox2
            // 
            this.NometextBox2.Location = new System.Drawing.Point(68, 85);
            this.NometextBox2.Name = "NometextBox2";
            this.NometextBox2.Size = new System.Drawing.Size(100, 20);
            this.NometextBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProdutoIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NometextBox2);
            this.Controls.Add(this.Nomelabel2);
            this.Controls.Add(this.IdtextBox1);
            this.Controls.Add(this.Idlabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdutoIncluir";
            this.Text = "ProdutoIncluir";
            this.Load += new System.EventHandler(this.ProdutoIncluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel1;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Label Nomelabel2;
        private System.Windows.Forms.TextBox NometextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}