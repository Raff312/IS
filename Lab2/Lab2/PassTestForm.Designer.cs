
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMiskatesInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountOfMistakes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountOfQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 613);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(469, 51);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNext.Location = new System.Drawing.Point(478, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(469, 51);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelComplete
            // 
            this.panelComplete.AutoScroll = true;
            this.panelComplete.BackColor = System.Drawing.Color.White;
            this.panelComplete.Controls.Add(this.lblPoint);
            this.panelComplete.Controls.Add(this.label7);
            this.panelComplete.Controls.Add(this.lblTheme);
            this.panelComplete.Controls.Add(this.lblDate);
            this.panelComplete.Controls.Add(this.lblLastName);
            this.panelComplete.Controls.Add(this.label6);
            this.panelComplete.Controls.Add(this.label5);
            this.panelComplete.Controls.Add(this.label4);
            this.panelComplete.Controls.Add(this.panelMiskatesInfo);
            this.panelComplete.Controls.Add(this.label3);
            this.panelComplete.Controls.Add(this.lblCountOfMistakes);
            this.panelComplete.Controls.Add(this.label2);
            this.panelComplete.Controls.Add(this.lblCountOfQuestions);
            this.panelComplete.Controls.Add(this.label1);
            this.panelComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComplete.Location = new System.Drawing.Point(0, 0);
            this.panelComplete.Name = "panelComplete";
            this.panelComplete.Size = new System.Drawing.Size(950, 613);
            this.panelComplete.TabIndex = 1;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(71, 59);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(0, 20);
            this.lblTheme.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(68, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(100, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 20);
            this.lblLastName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Тема: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Фамилия: ";
            // 
            // panelMiskatesInfo
            // 
            this.panelMiskatesInfo.AutoScroll = true;
            this.panelMiskatesInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelMiskatesInfo.Location = new System.Drawing.Point(13, 154);
            this.panelMiskatesInfo.Name = "panelMiskatesInfo";
            this.panelMiskatesInfo.Size = new System.Drawing.Size(925, 453);
            this.panelMiskatesInfo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подробнее об ошибках";
            // 
            // lblCountOfMistakes
            // 
            this.lblCountOfMistakes.AutoSize = true;
            this.lblCountOfMistakes.Location = new System.Drawing.Point(263, 108);
            this.lblCountOfMistakes.Name = "lblCountOfMistakes";
            this.lblCountOfMistakes.Size = new System.Drawing.Size(0, 20);
            this.lblCountOfMistakes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество правильных ответов: ";
            // 
            // lblCountOfQuestions
            // 
            this.lblCountOfQuestions.AutoSize = true;
            this.lblCountOfQuestions.Location = new System.Drawing.Point(188, 87);
            this.lblCountOfQuestions.Name = "lblCountOfQuestions";
            this.lblCountOfQuestions.Size = new System.Drawing.Size(0, 20);
            this.lblCountOfQuestions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество вопросов: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Оценка:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(836, 24);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(0, 20);
            this.lblPoint.TabIndex = 13;
            // 
            // PassTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 670);
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
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPoint;
    }
}