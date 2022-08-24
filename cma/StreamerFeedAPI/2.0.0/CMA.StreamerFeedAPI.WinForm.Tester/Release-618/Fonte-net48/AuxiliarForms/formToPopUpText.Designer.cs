namespace CMA.StreamerFeedAPI.WinForm.Tester.AuxiliarForms
{
    partial class formToPopUpText
    {

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formToPopUpText));
            this.richTextBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBody
            // 
            this.richTextBody.Location = new System.Drawing.Point(3, 3);
            this.richTextBody.Name = "richTextBody";
            this.richTextBody.ReadOnly = true;
            this.richTextBody.Size = new System.Drawing.Size(607, 252);
            this.richTextBody.TabIndex = 0;
            this.richTextBody.Text = "";
            // 
            // formToPopUpText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 255);
            this.Controls.Add(this.richTextBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formToPopUpText";
            this.Text = "formToPopUpText";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        //private System.ComponentModel.IContainer components;
        private System.Windows.Forms.RichTextBox richTextBody { get; set; }
    }
}

