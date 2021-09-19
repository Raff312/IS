
namespace Lab2 {
    partial class PassTestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelComplete = new System.Windows.Forms.Panel();
            this.panelMiskatesInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountOfMistakes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountOfQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelComplete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 393);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(394, 51);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(403, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(394, 51);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelComplete
            // 
            this.panelComplete.AutoScroll = true;
            this.panelComplete.BackColor = System.Drawing.Color.White;
            this.panelComplete.Controls.Add(this.panelMiskatesInfo);
            this.panelComplete.Controls.Add(this.label3);
            this.panelComplete.Controls.Add(this.lblCountOfMistakes);
            this.panelComplete.Controls.Add(this.label2);
            this.panelComplete.Controls.Add(this.lblCountOfQuestions);
            this.panelComplete.Controls.Add(this.label1);
            this.panelComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComplete.Location = new System.Drawing.Point(0, 0);
            this.panelComplete.Name = "panelComplete";
            this.panelComplete.Size = new System.Drawing.Size(800, 393);
            this.panelComplete.TabIndex = 1;
            // 
            // panelMiskatesInfo
            // 
            this.panelMiskatesInfo.AutoScroll = true;
            this.panelMiskatesInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelMiskatesInfo.Location = new System.Drawing.Point(13, 81);
            this.panelMiskatesInfo.Name = "panelMiskatesInfo";
            this.panelMiskatesInfo.Size = new System.Drawing.Size(775, 306);
            this.panelMiskatesInfo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подробнее";
            // 
            // lblCountOfMistakes
            // 
            this.lblCountOfMistakes.AutoSize = true;
            this.lblCountOfMistakes.Location = new System.Drawing.Point(282, 33);
            this.lblCountOfMistakes.Name = "lblCountOfMistakes";
            this.lblCountOfMistakes.Size = new System.Drawing.Size(0, 20);
            this.lblCountOfMistakes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество неправильных ответов: ";
            // 
            // lblCountOfQuestions
            // 
            this.lblCountOfQuestions.AutoSize = true;
            this.lblCountOfQuestions.Location = new System.Drawing.Point(188, 13);
            this.lblCountOfQuestions.Name = "lblCountOfQuestions";
            this.lblCountOfQuestions.Size = new System.Drawing.Size(0, 20);
            this.lblCountOfQuestions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество вопросов: ";
            // 
            // PassTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelComplete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PassTestForm";
            this.Text = "PassTestForm";
            this.Load += new System.EventHandler(this.PassTestForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelComplete.ResumeLayout(false);
            this.panelComplete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelComplete;
        private System.Windows.Forms.Panel panelMiskatesInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountOfMistakes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountOfQuestions;
        private System.Windows.Forms.Label label1;
    }
}