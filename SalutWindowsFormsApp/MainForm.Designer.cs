namespace SalutWindowsFormsApp
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
            this.salutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salutButton
            // 
            this.salutButton.Location = new System.Drawing.Point(686, 12);
            this.salutButton.Name = "salutButton";
            this.salutButton.Size = new System.Drawing.Size(93, 24);
            this.salutButton.TabIndex = 0;
            this.salutButton.Text = "Салют";
            this.salutButton.UseVisualStyleBackColor = true;
            this.salutButton.Click += new System.EventHandler(this.salutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salutButton);
            this.Name = "MainForm";
            this.Text = "Салют";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salutButton;
    }
}

