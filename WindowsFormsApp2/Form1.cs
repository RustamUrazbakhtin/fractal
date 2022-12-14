using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int _widthPicture;
        private int _heightPicture;

        public Form1()
        {
            InitializeComponent();
        }

        public void DrawFractal(int w, int h, Graphics g, Pen pen)
        {
            try
            {
                // при каждой итерации, вычисляется znew = zold² + С
                // вещественная  и мнимая части постоянной C
                double cRe;
                double cIm;

                // вещественная и мнимая части старой и новой
                double newRe;
                double newIm;
                double oldRe; 
                double oldIm;

                // Можно увеличивать и изменять положение
                double zoom = 1;
                double moveX = 0;
                double moveY = 0;

                //Определяем после какого числа итераций функция должна прекратить свою работу
                int maxIterations = 300;

                //выбираем несколько значений константы С, это определяет форму фрактала Жюлиа
                Random rand = new Random();
                cRe = rand.Next(-99999, 0) * 0.00001;
                cIm = rand.Next(-99999, 0) * 0.00001;
                

                
                //"перебираем" каждый пиксель
                for (int x = 0; x < w; x++)
                    for (int y = 0; y < h; y++)
                    {
                        //вычисляется реальная и мнимая части числа z
                        //на основе расположения пикселей,масштабирования и значения позиции
                        newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                        newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;

                        //i представляет собой число итераций 
                        int i;

                        //начинается процесс итерации
                        for (i = 0; i < maxIterations; i++)
                        {
                            //Запоминаем значение предыдущей итерации
                            oldRe = newRe;
                            oldIm = newIm;

                            // в текущей итерации вычисляются действительная и мнимая части 
                            newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                            newIm = 2 * oldRe * oldIm + cIm;

                            // если точка находится вне круга с радиусом 2 - прерываемся
                            if ((newRe * newRe + newIm * newIm) > 4) break;
                        }

                        //определяем цвета
                        pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                        //рисуем пиксель
                        g.DrawRectangle(pen, x, y, 1, 1);
                    }
            }
            catch (Exception ex)
            {
                // Обработчик ошибок
                MessageBox.Show(ex.Message);
            }
        }

        private async void StartBtn_Click (object sender, EventArgs e)
        {
            // Размеры картинки
            _widthPicture = pictureBox1.Width;
            _heightPicture = pictureBox1.Height;

            //Выбираем перо "myPen" черного цвета Black
            //толщиной в 1 пиксель:
            Pen myPen = new Pen(Color.Black, 1);

            //Объявляем объект "g" класса Graphics и предоставляем
            //ему возможность рисования на pictureBox1:
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            //вызываем функцию рисования фрактала
            //await Task.Run(() => DrawFractal(840, 620, g, myPen));
            await Task.Run(() => DrawFractal(_widthPicture, _heightPicture, g, myPen));
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
