using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossAndZero
{
    public partial class Form1 : Form
    {
        TicTacToe ttt = new TicTacToe();
        public Form1()
        {
            InitializeComponent();
        }
        public class TicTacToe
        {
            public Button[] button = new Button[9];
            public Label Step = new Label();
            public Label GameNumber = new Label();
            public Label Score = new Label();

            public int i; //счетчик ходов
            public int num_game; // номер игры
            public int Ovin; // количество побед О
            public  int Xvin; // количество побед Х
            public string[] arr = new string[10]; // массив, который хранит расположение Х и О на игровом поле
            public string t; // переменная которая показывает чей ход происходит
            public void Initializes()
            {
                for (int i = 0, x = 45, y = 65; i < 9; i++)
                {
                    if (i == 3 || i == 6)
                    {
                        y += 106;
                        x = 45;
                    }
                    button[i] = new Button
                    {
                        Tag = i,
                        Size = new Size(100, 100),
                        FlatStyle = FlatStyle.Flat,
                        UseVisualStyleBackColor = true,
                        Enabled = true,
                        Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 204),
                        ForeColor = Color.Black,
                        Location = new Point(x, y),
                        BackColor = Color.White,

                    };
                    button[i].FlatAppearance.BorderColor = Color.Maroon;
                    button[i].FlatAppearance.BorderSize = 2;
                    button[i].Click += button_click;
                    ActiveForm.Controls.Add(button[i]);
                    x += 106;
                }

                Step = new Label
                {
                    Location = new Point(button[0].Location.X, button[0].Location.Y - 25),
                    Size = new Size(100, 20),
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                GameNumber = new Label
                {
                    Location = new Point(button[1].Location.X, button[1].Location.Y - 25),
                    Size = new Size(100, 20),
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Score = new Label
                {
                    Location = new Point(button[2].Location.X, button[2].Location.Y - 25),
                    Size = new Size(100, 20),
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                void button_click(object sender, EventArgs e)
                {
                    Button b = (Button)sender;

                    if (b.Text == "X" || b.Text == "O") // если клетка уже заполненая
                    {
                        MessageBox.Show("КНОПКА ЗАПОЛНЕНА!");// предупреждаем, что нельзя
                    }
                    else
                    {
                        b.Text = Game((int)b.Tag + 1);
                        who_vin();
                    }// если все хорошо, запускаем 2 функции. задаем клетке отметку Х или О
                }
                ActiveForm.Controls.Add(Step);
                ActiveForm.Controls.Add(GameNumber);
                ActiveForm.Controls.Add(Score);
            } //инициализация кнопок и надписей

            public string Game(int j)
            {
                string fakeT; // переменная следущего хода
                if (i % 2 == 1) // узнает чей ход сделан (Х - непарный ход)
                {
                    t = "X";
                    fakeT = "O";
                }
                else
                {
                    t = "O";
                    fakeT = "X";
                }
                fakeT = "Ходит " + fakeT;
                arr[j] = t;
                i += 1;
                Step.Text = fakeT;// пишет кто следущий ходит
                return t; // возвращает отметку на поле Х или О
            } //принимает номер клетки поля

            public void who_vin()
            {
                if ((arr[1] == "X" & arr[2] == "X" & arr[3] == "X") | (arr[1] == "X" & arr[5] == "X" & arr[9] == "X") | (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") | (arr[2] == "X" & arr[5] == "X" & arr[8] == "X") | (arr[3] == "X" & arr[6] == "X" & arr[9] == "X") | (arr[3] == "X" & arr[5] == "X" & arr[7] == "X") | (arr[4] == "X" & arr[5] == "X" & arr[6] == "X") | (arr[7] == "X" & arr[8] == "X" & arr[9] == "X"))
                { // при таких обстоятельств побеждает Х
                    Xvin += 1; // начисляем ему победу

                    Score.Text = "Счёт: " + Xvin.ToString() + " : " + Ovin.ToString(); // обновляем табло побед
                    MessageBox.Show("Игрок ходивший X победил!"); // выводим окошечко, которое говорит нам о победе
                    refresch();// чистим поле, начинаем новую игру
                }

                if ((arr[1] == "O" & arr[2] == "O" & arr[3] == "O") | (arr[1] == "O" & arr[5] == "O" & arr[9] == "O") | (arr[1] == "O" & arr[4] == "O" & arr[7] == "O") | (arr[2] == "O" & arr[5] == "O" & arr[8] == "O") | (arr[3] == "O" & arr[6] == "O" & arr[9] == "O") | (arr[3] == "O" & arr[5] == "O" & arr[7] == "O") | (arr[4] == "O" & arr[5] == "O" & arr[6] == "O") | (arr[7] == "O" & arr[8] == "O" & arr[9] == "O"))
                {// при таких обстоятельств побеждает О, следущие действия аналогичны
                    Ovin += 1;

                    Score.Text = "Счёт: " + Xvin.ToString() + " : " + Ovin.ToString();
                    MessageBox.Show("Игрок ходивший О победил!");
                    refresch();
                }
                if ((arr[1] != "") & (arr[2] != "") & (arr[3] != "") & (arr[4] != "") & (arr[5] != "") & (arr[7] != "") & (arr[8] != "") & (arr[9] != ""))
                {// Ничья, тоесть все поле заполнено, а победителя нет
                    MessageBox.Show(" НИЧЬЯ! :)"); // объявляем ничью
                    refresch();// чистим поле
                }
            } //определяет кто победил

            public void refresch()
            {
                for (int i = 0; i < 9; i++)
                {
                    button[i].Text = "";
                }

                for (i = 0; i < 10; i += 1) // массив ходов
                {
                    arr[i] = "";
                }

                i = 1; // номер хода
                num_game += 1; // добавляем к номеру игры
                GameNumber.Text = num_game + " игра"; // обновляем табло с номером игры
                Step.Text = "Ходит X";
            } //игра заново
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttt.refresch();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Activate(); //фокус на эту форму
            ttt.Initializes(); //инициализация игры
            ttt.refresch(); //чистим поле перед игрой
            ttt.Score.Text = "Счёт: "+ttt.Xvin.ToString() + " : " + ttt.Ovin.ToString(); // задаем счетчик
        }
        private void цветФонаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            for (int i = 0; i < 9; i++) ttt.button[i].BackColor = colorDialog.Color;
        }
        private void цветКонтураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            for (int i = 0; i < 9; i++) ttt.button[i].FlatAppearance.BorderColor = colorDialog.Color;
        }
        private void толщинаКонтураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Введите размер:"));
            for (int i = 0; i < 9; i++) ttt.button[i].FlatAppearance.BorderSize = size;
        }
        private void цветЭлеметаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            for (int i = 0; i < 9; i++) ttt.button[i].ForeColor = colorDialog.Color;
        }
        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }
    }
}
