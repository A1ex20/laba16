using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        //Задание 1
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            //Создаем массив из 5 элементов
            string[] newFive = new string[5] { "Первый", "Второй", "Третий", "Четвертый", "Пятый"};
            //Создаем стек
            Stack<string> NewStack = new Stack<string>();
                for (int i = 0; i < 5; i++)
                {
                //добавляем в стек эл-ты из массива
                    NewStack.Push(newFive[i]);                    
                }
                foreach (var vivvodEl in NewStack) label2.Text += vivvodEl + " ";
                //удаляем из стека два эл-та
                for (int i = 0; i < 2; i++)
                { NewStack.Pop(); }
                foreach (var vivvodEl in NewStack) label3.Text += vivvodEl + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            int kolvo = Convert.ToInt32(textBox1.Text);
            Stack<int> NewStack = new Stack<int>();
            for (int i = 0; i < kolvo; i++)
            {
                NewStack.Push(i);
            }
            foreach (var vivvodEl in NewStack) label2.Text += vivvodEl + " ";
            for (int i = 0; i < 2; i++)
            { NewStack.Pop(); }
            foreach (var vivvodEl in NewStack) label3.Text += vivvodEl + " ";

        }
        //Задание 2
        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Эл-ты в обратном порядке: ";
            string[] Mas = new string[10] {"один",
                "два", 
                "три", 
                "четыре",
                "пять", 
                "шесть", 
                "семь", 
                "восемь", 
                "девять", 
                "десять" };
            Queue<string> NewQue = new Queue<string>();
            //добавление 10 элементов в конец очереди
            for (int i = 0; i < 10; i++)
            { NewQue.Enqueue(Mas[i]); }
            foreach (var viv in NewQue) label6.Text += viv + " ";
            label6.Text += "\nЭ-ты которые остались: ";
            //извлечение 5 элементов
            for (int i = 0; i < 5; i++)
            { NewQue.Dequeue(); }
            foreach (var viv in NewQue) label6.Text += viv + " ";
            //просмотр первого эл-та
            label6.Text += "\nПервый эл-т: ";
            label6.Text += NewQue.Peek();
            //Удаляем все эл-ты
           NewQue.Clear();
            label6.Text += "\nОчистка!";
            foreach (var viv in NewQue) label6.Text += viv + " ";
            //Проверяем пуст ли стак
            if (NewQue.Count() > 0)
            {

                label6.Text += "\nСтак не пуст"; 
            }
            else
            {
                label6.Text += "\nСтак пуст";
            }

        }
    }
}
