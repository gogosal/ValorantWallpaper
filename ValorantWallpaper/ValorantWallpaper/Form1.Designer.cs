namespace ValorantWallpaper
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
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_ValorantPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(143, 40);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(94, 34);
            this.btn_Set.TabIndex = 2;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_ValorantPath
            // 
            this.btn_ValorantPath.Location = new System.Drawing.Point(29, 40);
            this.btn_ValorantPath.Name = "btn_ValorantPath";
            this.btn_ValorantPath.Size = new System.Drawing.Size(94, 34);
            this.btn_ValorantPath.TabIndex = 0;
            this.btn_ValorantPath.Text = "Select";
            this.btn_ValorantPath.UseVisualStyleBackColor = true;
            this.btn_ValorantPath.Click += new System.EventHandler(this.btn_ValorantPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 126);
            this.Controls.Add(this.btn_ValorantPath);
            this.Controls.Add(this.btn_Set);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValorantWallpaper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_ValorantPath;
    }
}

