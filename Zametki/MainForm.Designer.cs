﻿namespace Notes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNoteButton = new System.Windows.Forms.Button();
            this.notesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.notesFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(13, 415);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(75, 23);
            this.addNoteButton.TabIndex = 1;
            this.addNoteButton.Text = "Добавить заметку";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // notesFlowLayoutPanel
            // 
            this.notesFlowLayoutPanel.Controls.Add(this.vScrollBar1);
            this.notesFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.notesFlowLayoutPanel.Name = "notesFlowLayoutPanel";
            this.notesFlowLayoutPanel.Size = new System.Drawing.Size(819, 397);
            this.notesFlowLayoutPanel.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 397);
            this.vScrollBar1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 475);
            this.Controls.Add(this.notesFlowLayoutPanel);
            this.Controls.Add(this.addNoteButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.notesFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.FlowLayoutPanel notesFlowLayoutPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

