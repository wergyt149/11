using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Student Program = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "Гулина";
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Text = "Дегтярев";
            tabControl1.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                Program.Plus(result);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Должно быть целое число");
                textBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int result))
            {
                Program.Minus(result);
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Должно быть целое число");
                textBox2.Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int result))
            {
                Program.Plus1(result);
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Должно быть целое число");
                textBox4.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int result))
            {
                Program.Minus1(result);
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Должно быть целое число");
                textBox3.Clear();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Program.DisplayAccountInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.DisplayAccountInfo1();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
class Student // Объявление класса Student
{
    // Приватные переменные для хранения информации 
    private double three;
    private double four;
    private double five;
    double max = 10;

    private double three1;
    private double four1;
    private double five1;

    public void Plus(double score) //Добавление оценок
    {
        if (score == 5 && five < max)
        {
            five++;
            MessageBox.Show($"Добавлена оценка 5. Текущее количество: {five} шт.");
        }
        else if (score == 4 && four < max)
        {
            four++;
            MessageBox.Show($"Добавлена оценка 4. Текущее количество: {four} шт.");
        }
        else if (score == 3 && three < max)
        {
            three++;
            MessageBox.Show($"Добавлена оценка 3. Текущее количество: {three} шт.");
        }
        else
        {
            MessageBox.Show("Некорректная оценка или превышено максимальное количество оценок.");
        }
    }
    public void Plus1(double score) //Добавление оценок
    {
        if (score == 5 && five1 < max)
        {
            five1++;
            MessageBox.Show($"Добавлена оценка 5. Текущее количество: {five1} шт.");
        }
        else if (score == 4 && four1 < max)
        {
            four1++;
            MessageBox.Show($"Добавлена оценка 4. Текущее количество: {four1} шт.");
        }
        else if (score == 3 && three1 < max)
        {
            three1++;
            MessageBox.Show($"Добавлена оценка 3. Текущее количество: {three1} шт.");
        }
        else
        {
            MessageBox.Show("Некорректная оценка или превышено максимальное количество оценок.");
        }
    }
    public void Minus(double score) //Снятие ошибок
    {
        if (score == 5 && five > 0)
        {
            five--;
            MessageBox.Show($"Снята оценка 5. Текущее количество: {five} шт.");
        }
        else if (score == 4 && four > 0)
        {
            four--;
            MessageBox.Show($"Снята оценка 4. Текущее количество: {four} шт.");
        }
        else if (score == 3 && three > 0)
        {
            three--;
            MessageBox.Show($"Снята оценка 3. Текущее количество: {three} шт.");
        }
        else
        {
            MessageBox.Show("Некорректная оценка или отсутствуют оценки для снятия.");
        }
    }
    public void Minus1(double score) //Снятие ошибок
    {
        if (score == 5 && five1 > 0)
        {
            five1--;
            MessageBox.Show($"Снята оценка 5. Текущее количество: {five1} шт.");
        }
        else if (score == 4 && four1 > 0)
        {
            four1--;
            MessageBox.Show($"Снята оценка 4. Текущее количество: {four1} шт.");
        }
        else if (score == 3 && three1 > 0)
        {
            three1--;
            MessageBox.Show($"Снята оценка 3. Текущее количество: {three1} шт.");
        }
        else
        {
            MessageBox.Show("Некорректная оценка или отсутствуют оценки для снятия.");
        }
    }

    public void DisplayAccountInfo() // Метод для вывода информации об аккаунте
    {
        MessageBox.Show($"Оценки: \nПятерки: {five} шт. \nЧетверки: {four} шт. \nТройки: {three} шт.");
    }
    public void DisplayAccountInfo1() // Метод для вывода информации об аккаунте
    {
        MessageBox.Show($"Оценки: \nПятерки: {five1} шт. \nЧетверки: {four1} шт. \nТройки: {three1} шт.");
    }
}