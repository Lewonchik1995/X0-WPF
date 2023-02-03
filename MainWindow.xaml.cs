using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace CrossZero
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Крестики-Нолики";
            Buttons_Blocked();
        }

        public bool isZeroTurn = false;
        public char[,] cells = new char[3, 3];
        int filled = 0;
        bool go = true;

        void Button_Click(object sender, RoutedEventArgs e)
        {
           Button? b = sender as Button;
            switch (b.Name)
            {
                case "TopLeft":
                    b.Content = Button(0, 0);
                    break;
                case "TopMiddle":
                    b.Content = Button(0, 1);
                    break;
                case "TopRight":
                    b.Content = Button(0, 2);
                    break;
                case "MiddleLeft":
                    b.Content = Button(1, 0);
                    break;
                case "Middle":
                    b.Content = Button(1, 1);
                    break;
                case "MiddleRight":
                    b.Content = Button(1, 2);
                    break;
                case "BottomLeft":
                    b.Content = Button(2, 0);
                    break;
                case "BottomMiddle":
                    b.Content = Button(2, 1);
                    break;
                case "BottomRight":
                    b.Content = Button(2, 2);
                    break;
            }
            e.Handled = true;
            isZeroTurn = !isZeroTurn;
            Buttons_Blocked();
            Winner();
            Bot_Click();
        }

        int Bot_Click()
        {
            if (filled < 9 && go == true)
            {
                Button[,] m_buttons = new Button[,] { { TopLeft, TopMiddle, TopRight }, { MiddleLeft, Middle, MiddleRight }, { BottomLeft, BottomMiddle, BottomRight } };
                Random rnd = new Random();
                int r = rnd.Next(0, 2);
                int c = rnd.Next(0, 2);
                if (cells[r, c] != '\0')
                {
                    do
                    {
                        r = rnd.Next(0, 3);
                        c = rnd.Next(0, 3);
                    }
                    while (cells[r, c] != '\0');
                    Thread.Sleep(3000);
                    m_buttons[r, c].Content = Button(r, c);
                }
                else
                {
                    Thread.Sleep(3000);
                    m_buttons[r, c].Content = Button(r, c);
                }
                isZeroTurn = !isZeroTurn;
                Buttons_UnBlock();
                Winner();
                return 0;
            }
            else
            {
                return 0;
            }
            return 0;
        }

        char Player()
        {
            if (isZeroTurn)
            {
                return '0';
            }
            else
            { 
                return 'X';
            }
        }

        char Button(int row, int collumn) 
        {
            char c = Player();
            cells[row, collumn] = c;
            return c;
        }

        void reset()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i,j] = '\0';
                }
            }
            Button[] buttons = new Button[] { TopLeft, TopMiddle, TopRight, MiddleLeft, Middle, MiddleRight, BottomLeft, BottomMiddle, BottomRight };
            foreach (var item in buttons)
            {
                item.Content = "";
            }
            Player();
            go = true;
        }

        private void Button_Click_New_Game(object sender, RoutedEventArgs e)
        {
            reset();
            Button[] buttons = new Button[] { TopLeft, TopMiddle, TopRight, MiddleLeft, Middle, MiddleRight, BottomLeft, BottomMiddle, BottomRight };
            foreach (var item in buttons)
            {
                item.IsEnabled = true;
            }
        }

        private void Buttons_UnBlock()
        {
            Button[] buttons = new Button[] { TopLeft, TopMiddle, TopRight, MiddleLeft, Middle, MiddleRight, BottomLeft, BottomMiddle, BottomRight };
            foreach (var item in buttons)
            {
                item.IsEnabled = true;
            }
        }

        private void Buttons_Blocked()
        {
            Button[] buttons = new Button[] { TopLeft, TopMiddle, TopRight, MiddleLeft, Middle, MiddleRight, BottomLeft, BottomMiddle, BottomRight };
            foreach (var item in buttons)
            {
                item.IsEnabled = false;
            }
        }

        char Winner_Check()
        {
            filled = 0;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(0); j++)
                {
                    if (cells[i, j] != '\0')
                        filled++;
                }
            }

            if (filled >= 5 && filled < 9)
            {
                if (cells[0, 0] == cells[0, 1] && cells[0, 1] == cells[0, 2] && cells[0, 2] == cells[0, 0]) //Top row
                    return cells[0, 0];
                else if (cells[1, 0] == cells[1, 1] && cells[1, 1] == cells[1, 2] && cells[1, 2] == cells[1, 0]) // Middle row
                    return cells[1, 0];
                else if (cells[2, 0] == cells[2, 1] && cells[2, 1] == cells[2, 2] && cells[2, 2] == cells[2, 0]) // Botton row
                    return cells[2, 0];
                else if (cells[0, 0] == cells[1, 0] && cells[1, 0] == cells[2, 0] && cells[2, 0] == cells[0, 0]) // Left collumn
                    return cells[0, 0];
                else if (cells[0, 1] == cells[1, 1] && cells[1, 1] == cells[2, 1] && cells[2, 1] == cells[0, 1]) // Middle collumn
                    return cells[0, 1];
                else if (cells[0, 2] == cells[1, 2] && cells[1, 2] == cells[2, 2] && cells[2, 2] == cells[0, 2]) // Right collumn
                    return cells[0, 2];
                else if (cells[0, 0] == cells[1, 1] && cells[1, 1] == cells[2, 2] && cells[2, 2] == cells[0, 0]) // Diagonal
                    return (cells[0, 0]);
                else if (cells[0, 2] == cells[1, 1] && cells[1, 1] == cells[2, 0] && cells[2, 0] == cells[0, 2]) // Diagonal
                    return (cells[0, 2]);
                else
                    return '\0';
            }
            else
            {
               if (filled == 9)
                    return 'N';
            }
            return '\0';
        }

        void Winner()
        {
            char res = Winner_Check();
            if (res == 'X') 
            {
                go = false;
                TurnDisplayer.Content = "Победили крестики!!!";
                Buttons_Blocked();
            }
            else if (res == '0')
            {
                go = false;
                TurnDisplayer.Content = "Победили нолики!!!";
                Buttons_Blocked();
            }
            else if (res == 'N')
            {
                go = false;
                TurnDisplayer.Content = "Ничья!!!";
                Buttons_Blocked();
            }
            else
            {
                TurnDisplayer.Content = "";
            }

        }
    }
}
