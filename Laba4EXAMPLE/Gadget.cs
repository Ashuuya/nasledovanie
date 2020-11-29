using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4EXAMPLE
{
    public class Gadget 
    {
        public int Inches = 7; // ДОБАВИЛ, КАК ОБЩЕЕ ПОЛЕ ВСЕХ ГАДЖЕТОВ

        // ТУТ ДОБАВИЛИ СЛОВО virtual ПОСЛЕ public
        // это надо чтобы функцию можно было переопределить
        // в классах наследниках
        public virtual string GetInfo()
        {
            // утащил сюда строчку с инфомацией о фрукте
            var str = String.Format("\nДиагональ экрана: {0}", this.Inches);
            return str;
        }

        // ДОБАВИЛ СТАТИЧЕСКОЕ ПОЛЕ rnd В БАЗОВЫЙ КЛАСС
        protected static Random rnd = new Random();

    }
    

    public class Laptop : Gadget 
    {
        public int CoresCount = 2;
        public int Winchester = 128;
        public bool Neon = false;

        public override String GetInfo()
        {
            var str = "Ноутбук";
            str += base.GetInfo();
            str += String.Format("\nКоличество ядер: {0}", this.CoresCount);
            str += String.Format("\nВнутреннее хранилище: {0}", this.Winchester);
            str += String.Format("\nНаличие подсветки клавиатуры: {0}", this.Neon);
            return str;
        }
        public static Laptop Generate()
        {
            return new Laptop
            {
                Inches = rnd.Next(14, 17), // экран
                CoresCount = rnd.Next(2, 6), // количество ядер ЦП
                Winchester = rnd.Next(128, 1024), // количество гигабайт во внутреннем хранилище
                Neon = rnd.Next() % 2 == 0 // наличие листика true или false
            };
        }
    }

    public enum CameraType { Yes, No };
    public class Tablet : Gadget // << И ТУТ Gadget
    {
        
        public int DPI = 300;
        public CameraType type = CameraType.Yes;

        public override String GetInfo()
        {
            var str = "Планшет";
            str += base.GetInfo();
            // Добавил
            str += String.Format("\nDPI экрана: {0}", this.DPI);
            str += String.Format("\nКамера: {0}", this.type);
            return str;
        }
        public static Tablet Generate()
        {
            return new Tablet
            {
                Inches = rnd.Next(7, 12), // экран
                DPI = rnd.Next(200, 500), // dpi
                type = (CameraType)rnd.Next(2) // есть камера или нет
            };
        }
    }

    public class Smartphone : Gadget // << И ЗДЕСЬ Gadget
    {
        
        public int MPixels = 8;
        public int mAh = 3000;
        public bool SIM2 = false;

        public override String GetInfo()
        {
            var str = "Смартфон";
            str += base.GetInfo();
            // Добавил
            str += String.Format("\nКоличество мегапикселей основной камеры: {0}", this.MPixels);
            str += String.Format("\nМощность батареи: {0}", this.mAh);
            str += String.Format("\nНаличие слота для 2 сим: {0}", this.SIM2);
            return str;
        }
        public static Smartphone Generate()
        {
            return new Smartphone
            {
                Inches = rnd.Next(4, 7), // экран
                MPixels = rnd.Next(8, 108), // количество мегапикселей основной камеры
                mAh = rnd.Next(2000, 7000), // мощность батарейки
                SIM2 = rnd.Next(2) == 0 // наличие 2 сим
            };
        }
    }
}