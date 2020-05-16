namespace DragonScaleCharSheet
{
    partial class FormMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadButton = new System.Windows.Forms.Button();
            this.createPCButton = new System.Windows.Forms.Button();
            this.createNPCButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(290, 45);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Załaduj Kartę Postaci";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // createPCButton
            // 
            this.createPCButton.Location = new System.Drawing.Point(12, 63);
            this.createPCButton.Name = "createPCButton";
            this.createPCButton.Size = new System.Drawing.Size(290, 45);
            this.createPCButton.TabIndex = 1;
            this.createPCButton.Text = "Stwórz Kartę Postaci";
            this.createPCButton.UseVisualStyleBackColor = true;
            this.createPCButton.Click += new System.EventHandler(this.createPCButton_Click);
            // 
            // createNPCButton
            // 
            this.createNPCButton.Location = new System.Drawing.Point(12, 114);
            this.createNPCButton.Name = "createNPCButton";
            this.createNPCButton.Size = new System.Drawing.Size(290, 45);
            this.createNPCButton.TabIndex = 2;
            this.createNPCButton.Text = "Stwórz NPC-a";
            this.createNPCButton.UseVisualStyleBackColor = true;
            this.createNPCButton.Click += new System.EventHandler(this.createNPCButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 165);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(290, 45);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 216);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(290, 45);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 272);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.createNPCButton);
            this.Controls.Add(this.createPCButton);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonScale KP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button createPCButton;
        private System.Windows.Forms.Button createNPCButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button closeButton;
    }
}

