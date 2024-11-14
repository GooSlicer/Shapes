### Программа про круги
## Начало
Сначала создается проект **Visual Studio**
----------------------------
## Код
```
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Brush? brush;
        readonly object locker = new();
        void Painter1()
        {
            brush = Brushes.Black;
            lock (locker)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(brush, 0, 0, 20, 20);
                graphics.Dispose();
            }
        }
        void Painter2()
        {
            brush = Brushes.DarkViolet;
            lock (locker)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillPie(brush, 60, 60, 100, 100, 20, 20);
                graphics.Dispose();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new(Painter1);
            Thread thread2 = new(Painter2);
            thread1.Start();
            thread2.Start();
        }
    }
}
```
-----------------------------

1. Отправляем в репозиторий
2. Друг получает файлик и меняет его
3. Друг отправляет нам
   1. или не отправляет
4. Мы получаем его справленный файлик

-----------------------------
   
## Ссылка
https://github.com/JumpInTheFire2010

-------------------

| круг | сектор |
|:-------:|:-------:|
| у меня  | не у меня  |
| у меня  | у меня  |

------------------------

### Величайшая цитата
>Пчела наш брат, кто забыл - я напомню
>>Bee is our bro, who forget - I remind

-------------------------

![Иконка](https://media.tenor.com/Y-Z4AKcohrsAAAAe/%D0%BA%D0%BE%D1%82-%D0%BB%D0%B8%D0%B6%D0%B5%D1%82.png)
