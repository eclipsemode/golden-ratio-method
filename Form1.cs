using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golden_ratio_method
{
    public partial class Form1 : Form
    {
        private GoldenMethod _goldenMethod = new GoldenMethod();
        private Func<double, double> fx = x => 4 - Math.Pow(x, 2) - 0.2 * Math.Pow(x, 3);
        public Form1()
        {
            InitializeComponent();
        }
        
        private void MainFormLoad(object sender, EventArgs e)
        {
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
            
            double a, b;

            // Получение значений от пользователя
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            
            _goldenMethod.Search(fx, a, b, 0.001);

            // Вывод результатов
            resultText.Text = "Результат работы:";
            lblResult.Text = "Экстремум функции: " + _goldenMethod.Optimal;
            lblSteps.Text = "Решение достигнуто за " + _goldenMethod.Steps + " шагов.";
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