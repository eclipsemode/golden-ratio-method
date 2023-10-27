using System.ComponentModel;

namespace Golden_ratio_method
{
    partial class Reference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 137);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для определения экстремума функции необходимо ввести данные в поле А и в поле B. " + "Далее необходимо нажать на кнопку \"расчитать\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 155);
            this.Controls.Add(this.label1);
            this.Name = "Reference";
            this.Text = "Справка";
            this.ResumeLayout(false);
        }

        #endregion
    }
}