using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        class Circle
        {
            public int x, y; // Координаты круга
            public int rad = 15; // Радиус круга
            public Color color = Color.Navy; // Выделен ли элемент
            public bool is_drawed = true; // Нарисован ли круг на полотне
            public Circle()
            {
                x = 0;
                y = 0;
            }
            public Circle(int x, int y)
            {
                this.x = x - rad;
                this.y = y - rad;
            }

            ~Circle() { }
        }

        private void paint_box_MouseMove(object sender, MouseEventArgs e)
        {
            label_x.Text = "X: " + e.X.ToString();
            label_y.Text = "Y: " + e.Y.ToString();
        }
        private void paint_circle(Color name, ref Storage stg, int index)
        {   // Рисует круг на панели            
            Pen pen = new Pen(name, 3);
            // Объявляем объект - карандаш, которым будем рисовать контур
            if (!storag.check_empty(index))
            {
                if (storag.objects[index].is_drawed == true)
                {
                    paint_box.CreateGraphics().DrawEllipse(
                    pen,
                    stg.objects[index].x,
                    stg.objects[index].y,
                    stg.objects[index].rad * 2,
                    stg.objects[index].rad * 2);
                    stg.objects[index].color = name;
                }
            }
        }

        private void remove_selection_circle(ref Storage stg)
        {   // Снимает выделение у всех элементов хранилища
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {   // Вызываем функцию отрисовки круга
                    paint_circle(Color.Navy, ref storag, i);
                }
            }
        }

        private void remove_selected_circle(ref Storage stg)
        {   // Удаляет выделенные элементы из хранилища
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    if (storag.objects[i].color == Color.Red)
                    {
                        storag.delete_object(i);
                    }
                }
            }
        }

        int p = 0; // Нажат ли был ранее Ctrl
        static int k = 5; // Кол-во ячеек в хранилище
        Storage storag = new Storage(k); // Создаем объект хранилища
        static int index = 0; // Кол-во нарисованных кругов
        int indexin = 0; // Индекс, в какое место был помещён круг

        private int check_circle(ref Storage stg, int size, int x, int y)
        {   // Проверяет есть ли уже круг с такими же координатами в хранилище
            if (stg.occupied(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.check_empty(i))
                    {
                        int x1 = stg.objects[i].x - 15;
                        int x2 = stg.objects[i].x + 15;
                        int y1 = stg.objects[i].y - 15;
                        int y2 = stg.objects[i].y + 15;

                        // Если круг есть, возвращет индекс круга в хранилище
                        if ((x1 <= x && x <= x2) && (y1 <= y && y <= y2))
                            return i;
                    }
                }
            }
            return -1;
        }

        private void button_clear_paintbox_Click(object sender, EventArgs e)
        {   // Очищает панель от кругов
            paint_box.Refresh(); // Перерисовывем панель paint_box

            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {   // Меняем is_drawed на false
                    storag.objects[i].is_drawed = false;
                }
            }
        }
        class Storage
        {
            public Circle[] objects;

            public Storage(int count)
            {   // Конструктор по умолчанию 
                // Выделяем count мест в хранилище
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void initialisat(int count)
            {   // Выделяем count мест в хранилище
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void add_object(int ind, ref Circle object1, int count, ref int indexin)
            {   // Добавляет ячейку в хранилище
                // Если ячейка занята ищем свободное место
                while (objects[ind] != null)
                {
                    ind = (ind + 1) % count;
                }
                objects[ind] = object1;
                indexin = ind;
            }
            public void delete_object(int ind)
            {   // Удаляет объект из хранилища
                objects[ind] = null;
                index--;
            }

            public bool check_empty(int index)
            {   // Проверяет занято ли место хранилище
                if (objects[index] == null)
                    return true;
                else return false;
            }

            public int occupied(int size)
            { // Определяет кол-во занятых мест в хранилище
                int count_occupied = 0;
                for (int i = 0; i < size; ++i)
                    if (!check_empty(i))
                        ++count_occupied;
                return count_occupied;
            }

            public void doubleSize(ref int size)
            {   // Функция для увеличения кол-ва элементов в хранилище в 2 раза 
                Storage storage1 = new Storage(size * 2);
                for (int i = 0; i < size; ++i)
                    storage1.objects[i] = objects[i];
                for (int i = size; i < (size * 2) - 1; ++i)
                {
                    storage1.objects[i] = null;
                }
                size = size * 2;
                initialisat(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = storage1.objects[i];
            }

            ~Storage() { }
        };
        private void button_show_Click(object sender, EventArgs e)
        {   // Отобразить все круги из хранилища
            paint_box.Refresh();
            if (storag.occupied(k) != 0)
            {

                for (int i = 0; i < k; ++i)
                {
                    if (!storag.check_empty(i))
                    {   // Меняем is_drawed на true
                        storag.objects[i].is_drawed = true;
                    }
                    paint_circle(Color.Navy, ref storag, i);
                }
            }

        }

        private void button_deletestorage_Click(object sender, EventArgs e)
        {   // Удалить все круги из хранилища
            for (int i = 0; i < k; ++i)
            {
                storag.objects[i] = null;
            }
            index = 0;
        }

        private void paint_box_MouseClick(object sender, MouseEventArgs e)
        {
            Circle krug = new Circle(e.X, e.Y);
            if (index == k)
                storag.doubleSize(ref k);
            // Проверка на наличие круга на данных координатах
            int c = check_circle(ref storag, k, krug.x, krug.y);
            if (c != -1)
            {   // Если на этом месте уже нарисован круг
                if (Control.ModifierKeys == Keys.Control)
                {   // Если нажат ctrl, то выделяем несколько объектов
                    if (p == 0)
                    {
                        paint_circle(Color.Navy, ref storag, indexin);
                        p = 1;
                    }
                    // Вызываем функцию отрисовки круга
                    paint_circle(Color.Red, ref storag, c);
                }
                else
                {   // Иначе выделяем только один объект
                    // Снимаем выделение у всех объектов хранилища
                    remove_selection_circle(ref storag);
                    // Вызываем функцию отрисовки круга
                    paint_circle(Color.Red, ref storag, c);
                }
                return;
            }
            // Добавляем круг в хранилище   
            storag.add_object(index, ref krug, k, ref indexin);
            // Снимаем выделение у всех объектов хранилища
            remove_selection_circle(ref storag);

            // Вызываем функцию отрисовки круга
            paint_circle(Color.Red, ref storag, indexin);
            ++index;
            p = 0;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                remove_selected_circle(ref storag);
                paint_box.Refresh();
                if (storag.occupied(k) != 0)
                {
                    for (int i = 0; i < k; ++i)
                    {
                        paint_circle(Color.Navy, ref storag, i);
                    }
                }
            }
        }
    }
}
