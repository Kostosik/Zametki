namespace Notes
{
    partial class UserControlNotes
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteSplitContainer = new System.Windows.Forms.SplitContainer();
            this.topTextBox = new System.Windows.Forms.TextBox();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noteSplitContainer)).BeginInit();
            this.noteSplitContainer.Panel1.SuspendLayout();
            this.noteSplitContainer.Panel2.SuspendLayout();
            this.noteSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteSplitContainer
            // 
            this.noteSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteSplitContainer.IsSplitterFixed = true;
            this.noteSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.noteSplitContainer.Name = "noteSplitContainer";
            this.noteSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // noteSplitContainer.Panel1
            // 
            this.noteSplitContainer.Panel1.Controls.Add(this.topTextBox);
            // 
            // noteSplitContainer.Panel2
            // 
            this.noteSplitContainer.Panel2.Controls.Add(this.noteRichTextBox);
            this.noteSplitContainer.Size = new System.Drawing.Size(251, 248);
            this.noteSplitContainer.SplitterDistance = 25;
            this.noteSplitContainer.TabIndex = 0;
            // 
            // topTextBox
            // 
            this.topTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTextBox.Location = new System.Drawing.Point(0, 0);
            this.topTextBox.Name = "topTextBox";
            this.topTextBox.Size = new System.Drawing.Size(251, 20);
            this.topTextBox.TabIndex = 0;
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.noteRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(251, 219);
            this.noteRichTextBox.TabIndex = 0;
            this.noteRichTextBox.Text = "";
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditButton.Location = new System.Drawing.Point(0, 225);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(251, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UserControlNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.noteSplitContainer);
            this.Name = "UserControlNotes";
            this.Size = new System.Drawing.Size(251, 248);
            this.Load += new System.EventHandler(this.UserControlNotes_Load);
            this.noteSplitContainer.Panel1.ResumeLayout(false);
            this.noteSplitContainer.Panel1.PerformLayout();
            this.noteSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteSplitContainer)).EndInit();
            this.noteSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer noteSplitContainer;
        private System.Windows.Forms.TextBox topTextBox;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.Button EditButton;
    }
}
