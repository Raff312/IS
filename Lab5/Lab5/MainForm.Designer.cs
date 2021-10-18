
namespace Lab5 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnSerpinski = new System.Windows.Forms.Button();
            this.BtnKoh = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSerpinski
            // 
            this.BtnSerpinski.Location = new System.Drawing.Point(13, 13);
            this.BtnSerpinski.Name = "BtnSerpinski";
            this.BtnSerpinski.Size = new System.Drawing.Size(94, 29);
            this.BtnSerpinski.TabIndex = 0;
            this.BtnSerpinski.Text = "Serpinski";
            this.BtnSerpinski.UseVisualStyleBackColor = true;
            this.BtnSerpinski.Click += new System.EventHandler(this.BtnSerpinski_Click);
            // 
            // BtnKoh
            // 
            this.BtnKoh.Location = new System.Drawing.Point(1115, 13);
            this.BtnKoh.Name = "BtnKoh";
            this.BtnKoh.Size = new System.Drawing.Size(94, 29);
            this.BtnKoh.TabIndex = 1;
            this.BtnKoh.Text = "Koh";
            this.BtnKoh.UseVisualStyleBackColor = true;
            this.BtnKoh.Click += new System.EventHandler(this.BtnKoh_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(13, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1196, 565);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 626);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.BtnKoh);
            this.Controls.Add(this.BtnSerpinski);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSerpinski;
        private System.Windows.Forms.Button BtnKoh;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

