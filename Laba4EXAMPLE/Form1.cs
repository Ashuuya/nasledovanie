using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4EXAMPLE
{
    public partial class Form1 : Form
    {
        // ДОБАВИЛ, важный момент что указываем тип Fruit
        List<Gadget> gadgetList = new List<Gadget>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // СЮДА, чтобы при запуске приложения что-то показывалось на форме
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.gadgetList.Count == 0)
            {
                txtOut.Text = "Раздатчик пуст";
                return;
            }

            // взяли первый фрукт
            var gadget = this.gadgetList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.gadgetList.RemoveAt(0);

            // ЗАМЕНИЛ НАШИ if`ы
            txtOut.Text = gadget.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }

        

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.gadgetList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.gadgetList.Add(Laptop.Generate());
                        break;
                    case 1:
                        this.gadgetList.Add(Tablet.Generate());
                        break;
                    case 2:
                        this.gadgetList.Add(Smartphone.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        // функция выводит информацию о количестве фруктов на форму
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int laptopsCount = 0;
            int tabletsCount = 0;
            int smartphonesCount = 0;

            // пройдёмся по всему списку
            foreach (var gadget in this.gadgetList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (gadget is Laptop) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    laptopsCount += 1;
                }
                else if (gadget is Tablet)
                {
                    tabletsCount += 1;
                }
                else if (gadget is Smartphone)
                {
                    smartphonesCount += 1;
                }
            }

            // ну и вывести все это надо на форму
            txtInfo.Text = "Ноутбук\t\t\t\tПланшет\t\t\t\tСмартфон";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t\t\t{1}\t\t\t\t{2}", laptopsCount, tabletsCount, smartphonesCount);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
