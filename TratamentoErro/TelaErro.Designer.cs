
namespace TratamentoErro
{
    partial class TelaErro
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
            this.buttonTeste = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTeste
            // 
            this.buttonTeste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTeste.Location = new System.Drawing.Point(154, 141);
            this.buttonTeste.Name = "buttonTeste";
            this.buttonTeste.Size = new System.Drawing.Size(75, 23);
            this.buttonTeste.TabIndex = 0;
            this.buttonTeste.Text = "Teste";
            this.buttonTeste.UseVisualStyleBackColor = false;
            this.buttonTeste.Click += new System.EventHandler(this.buttonTeste_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelResultado.Location = new System.Drawing.Point(129, 58);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(135, 47);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonThrow
            // 
            this.buttonThrow.BackColor = System.Drawing.SystemColors.Info;
            this.buttonThrow.Location = new System.Drawing.Point(154, 184);
            this.buttonThrow.Name = "buttonThrow";
            this.buttonThrow.Size = new System.Drawing.Size(75, 23);
            this.buttonThrow.TabIndex = 2;
            this.buttonThrow.Text = "Throw";
            this.buttonThrow.UseVisualStyleBackColor = false;
            this.buttonThrow.Click += new System.EventHandler(this.buttonThrow_Click);
            // 
            // TelaErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 234);
            this.Controls.Add(this.buttonThrow);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaErro";
            this.Text = "Tela de Erro :: Try Catch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTeste;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonThrow;
    }
}

