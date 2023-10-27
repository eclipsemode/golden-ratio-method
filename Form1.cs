using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golden_ratio_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void MainFormLoad(object sender, EventArgs e)
        {
        }
        private double F(double x)
        {
            return Math.Atan(x) * Math.Cos(x) + 1;
        }
        private void BtnCalculateClick(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Введите входные данные");
                // Обнуление результатов:
                resultText.Text = "";
                lblResult.Text = "";
                lblSteps.Text = "";
                return;
            }
            
            double a, b, x1, x2;
            double eps = 0.001;
            int n = 0;

            // Получение значений от пользователя
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            x1 = a + 0.381966 * (b - a);
            x2 = a + 0.618034 * (b - a);

            while ((b - a) > eps)
            {
                if (F(x1) < F(x2))
                {
                    a = x1;
                    x1 = a + 0.381966 * (b - a);
                    x2 = a + 0.618034 * (b - a);
                }
                if (F(x1) > F(x2))
                {
                    b = x2;
                    x1 = a + 0.381966 * (b - a);
                    x2 = a + 0.618034 * (b - a);
                }
                n++;
            }

            // Вывод результатов
            resultText.Text = "Результат работы:";
            lblResult.Text = "Экстремум функции f(" + (b + a) / 2.0 + ") = " + F((b + a) / 2.0);
            lblSteps.Text = "Решение достигнуто за " + n + " шагов.";
        }
        
        // Пользовательский класс TextBox с плейсхолдером
        public class TextBoxPlaceholder : TextBox
        {
            private const int WM_PAINT = 0xF;

            public virtual string PlaceholderText { get; set; }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == WM_PAINT && string.IsNullOrEmpty(Text) && !Focused)
                {
                    using (Graphics graphics = CreateGraphics())
                    {
                        TextRenderer.DrawText(graphics, PlaceholderText, Font, ClientRectangle, SystemColors.GrayText,
                            BackColor, TextFormatFlags.Left);
                    }
                }
            }
        }
        
        //справка о программе
        private void ReferenceClick(object sender, EventArgs e)
        {
            Reference reference = new Reference();
            reference.Show();
        }

        //разработчик программы
        private void DeveloperClick(object sender, EventArgs e)
        {
            Developer developer = new Developer();
            developer.Show();
        }
        
    }
}