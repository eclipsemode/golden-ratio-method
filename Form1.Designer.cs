namespace Golden_ratio_method
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMain;
        private TextBoxPlaceholder txtA;
        private TextBoxPlaceholder txtB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button btnCalculate;

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
            this.txtA = new Golden_ratio_method.Form1.TextBoxPlaceholder();
            this.txtB = new Golden_ratio_method.Form1.TextBoxPlaceholder();
            this.labelMain = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(251, 100);
            this.txtA.Name = "txtA";
            this.txtA.PlaceholderText = "Введите значение a";
            this.txtA.Size = new System.Drawing.Size(115, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(382, 100);
            this.txtB.Name = "txtB";
            this.txtB.PlaceholderText = "Введите значение b";
            this.txtB.Size = new System.Drawing.Size(115, 20);
            this.txtB.TabIndex = 1;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(287, 73);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(163, 13);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "Введите границы отрезка [a,b]";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(318, 185);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(102, 13);
            this.resultText.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(200, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(270, 230);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(0, 13);
            this.lblSteps.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(318, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculateClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 386);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Нахождение экстремума функции методом золотого сечения";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelM;

        #endregion
    }
}