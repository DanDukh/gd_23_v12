using System;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long GetFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            long num1 = 0;
            long num2 = 1;

            for (int i = 1; i < n; i++)
            {
                var num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            return num2;
        }

        private void getResultButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputTextbox.Text, out int index))
            {
                if (index < 0)
                {
                    MessageBox.Show("Порядковый номер не может быть отрицательным", "Ошибка!");
                }
                else if (index > 92)
                {
                    MessageBox.Show("Число Фибоначчи с таким номером слишком велико. Попробуйте ввести номер меньше 92", "Ошибка!");
                }
                else
                {
                    outputTextbox.Text = GetFibonacci(index).ToString();
                }
            }
            else
            {
                MessageBox.Show("Порядковый номер числа Фибоначчи введен некорректно!", "Ошибка!");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = "";
            outputTextbox.Text = "";
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Приложение выполняет функцию расчета n-го числа членов ряда чисел Фиббоначчи.

Для получения числа Фибоначчи необходимо заполнить поле 'Порядковый номер' и нажать на кнопку 'Получить ответ'.
Кнопка 'Сбросить' сбрасывает значения полей ввода и вывода.
", "Руководство пользователя");
        }
    }
}
