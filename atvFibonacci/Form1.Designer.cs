namespace atvFibonacci
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.fiboRes = new System.Windows.Forms.TextBox();
            this.getIndex = new System.Windows.Forms.Button();
            this.getSequence = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequência Fibonnaci em C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o indice :";
            // 
            // numeroInput
            // 
            this.numeroInput.Location = new System.Drawing.Point(132, 98);
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.Size = new System.Drawing.Size(100, 20);
            this.numeroInput.TabIndex = 2;
            // 
            // fiboRes
            // 
            this.fiboRes.Location = new System.Drawing.Point(42, 197);
            this.fiboRes.Multiline = true;
            this.fiboRes.Name = "fiboRes";
            this.fiboRes.Size = new System.Drawing.Size(341, 119);
            this.fiboRes.TabIndex = 3;
            // 
            // getIndex
            // 
            this.getIndex.Location = new System.Drawing.Point(283, 124);
            this.getIndex.Name = "getIndex";
            this.getIndex.Size = new System.Drawing.Size(100, 23);
            this.getIndex.TabIndex = 4;
            this.getIndex.Text = "Pegar o número";
            this.getIndex.UseVisualStyleBackColor = true;
            this.getIndex.Click += new System.EventHandler(this.getIndex_Click);
            // 
            // getSequence
            // 
            this.getSequence.Location = new System.Drawing.Point(283, 95);
            this.getSequence.Name = "getSequence";
            this.getSequence.Size = new System.Drawing.Size(100, 23);
            this.getSequence.TabIndex = 5;
            this.getSequence.Text = "Pegar sequência";
            this.getSequence.UseVisualStyleBackColor = true;
            this.getSequence.Click += new System.EventHandler(this.getSequence_Click);
            // 
            // clearFields
            // 
            this.clearFields.Location = new System.Drawing.Point(42, 134);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(100, 23);
            this.clearFields.TabIndex = 6;
            this.clearFields.Text = "Limpar Campos";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 369);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.getSequence);
            this.Controls.Add(this.getIndex);
            this.Controls.Add(this.fiboRes);
            this.Controls.Add(this.numeroInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeroInput;
        private System.Windows.Forms.TextBox fiboRes;
        private System.Windows.Forms.Button getIndex;
        private System.Windows.Forms.Button getSequence;
        private System.Windows.Forms.Button clearFields;
    }
}

