using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //int mistakes = 0;
        string word = "";
        int num_letters;
        int num_words;
        //System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); толком не работало
        DateTime date1 = new DateTime();

        void Clear() { textblock1.Text = word = textbox2.Text = ""; }

        void Check()
        {
            int mistakes = 0;
            for (int i = 0; i < textbox2.Text.Length; i++)
            {
                if (textbox2.Text[i] != word[i])
                {
                    mistakes++;
                }
            }
            Fails.Text = Convert.ToString(mistakes);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Clear();
            textbox2.IsEnabled = true;
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();// Создаем массив букв, которые мы будем использовать.

            Random rand = new Random();// Создаем генератор случайных чисел.            

            for (int i = 1; i <= num_words; i++)// Делаем слова.
            {
                for (int j = 1; j <= num_letters; j++)// Сделайте слово.
                {
                    // Выбор случайного числа от 0 до 25// для выбора буквы из массива букв.                    
                    int letter_num = rand.Next(0, letters.Length - 1);
                    word += letters[letter_num];
                }
                word += " ";
            }
            textblock1.Text = word;
            StartButton.IsEnabled = false;
            Slider.IsEnabled = false;

            textbox2.Focus();
            date1 = DateTime.Now;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue == 1)
            {
                num_letters = 3;
                num_words = 3;
                DifficultyNomber.Text = "1";
            }
            if (e.NewValue == 2)
            {
                num_letters = 4;
                num_words = 3;
                DifficultyNomber.Text = "2";
            }
            if (e.NewValue == 3)
            {
                num_letters = 5;
                num_words = 4;
                DifficultyNomber.Text = "3";
            }
            if (e.NewValue == 4)
            {
                num_letters = 6;
                num_words = 5;
                DifficultyNomber.Text = "4";
            }
            if (e.NewValue == 5)
            {
                num_letters = 7;
                num_words = 6;
                DifficultyNomber.Text = "5";
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Speed.Text = "0";
            StartButton.IsEnabled = true;
            Slider.IsEnabled = true;
        }

        private void Grid_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (textbox2.Text.Length <= word.Length) { Check(); }

            if (textbox2.Text.Length == word.Length && word.Length != 0)
            {
                textbox2.IsEnabled = false;
                var aa = DateTime.Now - date1;
                Speed.Text = Convert.ToString(Convert.ToInt32(60 / aa.TotalSeconds * word.Length));

                if (Fails.Text == "0")
                {
                    MessageBox.Show("You are Good!!!");
                }
            }
        }

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Q) { bord_q.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.W) { bord_w.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.E) { bord_e.Background = new SolidColorBrush(Color.FromRgb(127, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.R) { bord_r.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.T) { bord_t.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.Y) { bord_y.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.U) { bord_u.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.I) { bord_i.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.O) { bord_o.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.P) { bord_p.Background = new SolidColorBrush(Color.FromRgb(127, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.A) { bord_a.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.S) { bord_s.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.D) { bord_d.Background = new SolidColorBrush(Color.FromRgb(127, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.F) { bord_f.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.G) { bord_g.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.H) { bord_h.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.J) { bord_j.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.K) { bord_k.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.L) { bord_l.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.Z) { bord_z.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.X) { bord_x.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.C) { bord_c.Background = new SolidColorBrush(Color.FromRgb(127, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.V) { bord_v.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.B) { bord_b.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.N) { bord_n.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.M) { bord_m.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }

            if (e.Key == System.Windows.Input.Key.D1) { one.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.D2) { two.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.D3) { three.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.D4) { four.Background = new SolidColorBrush(Color.FromRgb(127, 237, 119)); }
            if (e.Key == System.Windows.Input.Key.D5) { five.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.D6) { six.Background = new SolidColorBrush(Color.FromRgb(119, 190, 240)); }
            if (e.Key == System.Windows.Input.Key.D7) { seven.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.D8) { eight.Background = new SolidColorBrush(Color.FromRgb(219, 119, 240)); }
            if (e.Key == System.Windows.Input.Key.D9) { nine.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150)); }
            if (e.Key == System.Windows.Input.Key.D0) { zero.Background = new SolidColorBrush(Color.FromRgb(235, 237, 119)); }


            if (e.Key == System.Windows.Input.Key.OemComma) bord_zap.Background = new SolidColorBrush(Color.FromRgb(240, 119, 150));
            // MessageBox.Show("` " + e.Key);

            if (e.Key == System.Windows.Input.Key.LeftShift || e.Key == System.Windows.Input.Key.RightShift)
            {
                q.Text = "q";
                w.Text = "w";
                ee.Text = "e";
                r.Text = "r";
                t.Text = "t";
                y.Text = "y";
                u.Text = "u";
                i.Text = "i";
                o.Text = "o";
                p.Text = "p";
                a.Text = "a";
                s.Text = "s";
                d.Text = "d";
                f.Text = "f";
                g.Text = "g";
                h.Text = "h";
                j.Text = "j";
                k.Text = "k";
                l.Text = "l";
                z.Text = "z";
                x.Text = "x";
                c.Text = "c";
                v.Text = "v";
                b.Text = "b";
                n.Text = "n";
                m.Text = "m";


            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Q) { bord_q.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.W) { bord_w.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }
            if (e.Key == System.Windows.Input.Key.E) { bord_e.Background = new SolidColorBrush(Color.FromRgb(40, 203, 31)); }
            if (e.Key == System.Windows.Input.Key.R) { bord_r.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.T) { bord_t.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.Y) { bord_y.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.U) { bord_u.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.I) { bord_i.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.O) { bord_o.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }
            if (e.Key == System.Windows.Input.Key.P) { bord_p.Background = new SolidColorBrush(Color.FromRgb(40, 203, 31)); }
            if (e.Key == System.Windows.Input.Key.A) { bord_a.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.S) { bord_s.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }
            if (e.Key == System.Windows.Input.Key.D) { bord_d.Background = new SolidColorBrush(Color.FromRgb(40, 203, 31)); }
            if (e.Key == System.Windows.Input.Key.F) { bord_f.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.G) { bord_g.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.H) { bord_h.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.J) { bord_j.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.K) { bord_k.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.L) { bord_l.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }
            if (e.Key == System.Windows.Input.Key.Z) { bord_z.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.X) { bord_x.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }
            if (e.Key == System.Windows.Input.Key.C) { bord_c.Background = new SolidColorBrush(Color.FromRgb(40, 203, 31)); }
            if (e.Key == System.Windows.Input.Key.V) { bord_v.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.B) { bord_b.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.N) { bord_n.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.M) { bord_m.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }

            if (e.Key == System.Windows.Input.Key.D1) { one.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.D2) { two.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.D3) { three.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }
            if (e.Key == System.Windows.Input.Key.D4) { four.Background = new SolidColorBrush(Color.FromRgb(40, 203, 31)); }
            if (e.Key == System.Windows.Input.Key.D5) { five.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.D6) { six.Background = new SolidColorBrush(Color.FromRgb(40, 130, 200)); }
            if (e.Key == System.Windows.Input.Key.D7) { seven.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.D8) { eight.Background = new SolidColorBrush(Color.FromRgb(150, 30, 190)); }
            if (e.Key == System.Windows.Input.Key.D9) { nine.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77)); }
            if (e.Key == System.Windows.Input.Key.D0) { zero.Background = new SolidColorBrush(Color.FromRgb(240, 207, 7)); }

            if (e.Key == System.Windows.Input.Key.OemComma) bord_zap.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77));
            if (e.Key == System.Windows.Input.Key.OemComma) bord_zap.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77));

            if (e.Key == System.Windows.Input.Key.LeftShift || e.Key == System.Windows.Input.Key.RightShift)
            {
                q.Text = "Q";
                w.Text = "W";
                ee.Text = "E";
                r.Text = "R";
                t.Text = "T";
                y.Text = "Y";
                u.Text = "U";
                i.Text = "I";
                o.Text = "O";
                p.Text = "P";
                a.Text = "A";
                s.Text = "S";
                d.Text = "D";
                f.Text = "F";
                g.Text = "G";
                h.Text = "H";
                j.Text = "J";
                k.Text = "K";
                l.Text = "L";
                z.Text = "Z";
                x.Text = "X";
                c.Text = "C";
                v.Text = "V";
                b.Text = "B";
                n.Text = "N";
                m.Text = "M";

                bord_zap.Background = new SolidColorBrush(Color.FromRgb(240, 23, 77));
            }
        }
    }
}
