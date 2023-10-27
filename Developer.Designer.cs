using System.ComponentModel;

namespace Golden_ratio_method
{
    partial class Developer
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
            // 
            // Developer
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 93);
            this.label1 = new System.Windows.Forms.Label();
            this.Text = "О разработчике";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label1);
            this.Name = "Developer";
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа выполнена студентом:\r\n Волконеско Данил Юрьевич\r\n\r\nГруппа:\r\n з-421П12-1";
        }

        #endregion
    }
}