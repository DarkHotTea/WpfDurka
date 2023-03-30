using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
using System.Windows.Media.Animation;
using MaterialDesignThemes.Wpf;

namespace WpfDurka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Question_Box.Text))
            {
                MessageBox.Show("Задайте вопрос!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Вопрос задан!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void StackPanel_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Label_1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00DAFF"));
            Label_1.Padding = new Thickness(2.5);
            Label_2.Padding = new Thickness(5);
            Label_3.Padding = new Thickness(5);
            Rectangle_1.Width = Label_1.Width;
            Label_2.Foreground = Brushes.Black;
            Rectangle_2.Width = 0;
            Label_3.Foreground = Brushes.Black;
            Rectangle_3.Width = 0;
            Tab_2.Visibility = Visibility.Collapsed;
            Tab_3.Visibility = Visibility.Collapsed;
            Tab_1.Visibility = Visibility.Visible;
        }

        private void StackPanel_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Label_2.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00DAFF"));
            Label_2.Padding = new Thickness(2.5);
            Label_3.Padding = new Thickness(5);
            Label_1.Padding = new Thickness(5);
            Rectangle_2.Width = Label_2.Width;
            Label_1.Foreground = Brushes.Black;
            Rectangle_1.Width = 0;
            Label_3.Foreground = Brushes.Black;
            Rectangle_3.Width = 0;
            Tab_3.Visibility = Visibility.Collapsed;
            Tab_1.Visibility = Visibility.Collapsed;
            Tab_2.Visibility = Visibility.Visible;
        }

        private void StackPanel_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Label_3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00DAFF"));
            Label_3.Padding = new Thickness(2.5);
            Label_2.Padding = new Thickness(5);
            Label_1.Padding = new Thickness(5);
            Rectangle_3.Width = Label_3.Width;
            Label_2.Foreground = Brushes.Black;
            Rectangle_2.Width = 0;
            Label_1.Foreground = Brushes.Black;
            Rectangle_1.Width = 0;
            Tab_2.Visibility = Visibility.Collapsed;
            Tab_1.Visibility = Visibility.Collapsed;
            Tab_3.Visibility = Visibility.Visible;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double part = ((this.ActualWidth - 320) / 1600);

            About_Title.FontSize = 24 + 26 * part;
            About_SubTitle.FontSize = 12 + 12 * part;
            About_SubTitle.Padding = new Thickness(0, 2 + 8 * part, 0,0);
            
            Rectangle_1.Height = 2.5 + 2 * part;
            Rectangle_2.Height = 2.5 + 2 * part;
            Rectangle_3.Height = 2.5 + 2 * part;

            Label_1.FontSize = 12 + 12 * part;
            Label_2.FontSize = 12 + 12 * part;
            Label_3.FontSize = 12 + 12 * part;

            Icon_1.Width = 25 + 55 * part;
            Icon_2.Width = 25 + 55 * part;
            Icon_3.Width = 25 + 55 * part;
            Icon_4.Width = 25 + 55 * part;
            Icon_5.Width = 25 + 55 * part;
            Icon_1.Height = 25 + 55 * part;
            Icon_2.Height = 25 + 55 * part;
            Icon_3.Height = 25 + 55 * part;
            Icon_4.Height = 25 + 55 * part;
            Icon_5.Height = 25 + 55 * part;
            Icon_1.Margin = new Thickness(0, 0, 5 + 15 * part,0);
            Icon_2.Margin = new Thickness(0, 0, 5 + 15 * part, 0);
            Icon_3.Margin = new Thickness(0, 0, 5 + 15 * part, 0);
            Icon_4.Margin = new Thickness(0, 0, 5 + 15 * part, 0);
            Icon_5.Margin = new Thickness(0, 0, 5 + 15 * part, 0);

            List_Title1.FontSize = 12 + 18 * part;
            List_Title2.FontSize = 12 + 18 * part;
            List_Title3.FontSize = 12 + 18 * part;
            List_Title4.FontSize = 12 + 18 * part;
            List_Title5.FontSize = 12 + 18 * part;
            List_Mark1.FontSize = 12 + 18 * part;
            List_Mark2.FontSize = 12 + 18 * part;
            List_Mark3.FontSize = 12 + 18 * part;
            List_Mark4.FontSize = 12 + 18 * part;
            List_Mark5.FontSize = 12 + 18 * part;

            List_Stack1.Margin = new Thickness(0, 3 + 17 * part, 0, 3 + 17 * part);
            List_Stack2.Margin = new Thickness(0, 3 + 17 * part, 0, 3 + 17 * part);
            List_Stack3.Margin = new Thickness(0, 3 + 17 * part, 0, 3 + 17 * part);
            List_Stack4.Margin = new Thickness(0, 3 + 17 * part, 0, 3 + 17 * part);
            List_Stack5.Margin = new Thickness(0, 3 + 17 * part, 0, 3 + 17 * part);

            Question_Title.FontSize = 26 + 16 * part;
            Question_Box.FontSize = 18 + 16 * part;

            CloseBtn.Width = 20 + 20 * part;
            MaxBtn.Width = 20 + 20 * part;
            CloseBtn_ico.Height = 22.5 + 25 * ((this.ActualHeight - 568) / 512);
            MaxBtn_ico.Height = 22.5 + 25 * ((this.ActualHeight - 568) / 512);
            CloseBtn_ico.Width = 20 + 20 * part;
            MaxBtn_ico.Width = 20 + 20 * part;

            if (this.ActualWidth > 600 && this.ActualWidth < 1000 && this.ActualHeight > 500 && this.ActualHeight < 700)
            {
                Photo_Doctor.Width = 275;
                Photo_Doctor.Height = 275;
            }
            if (this.ActualWidth <= 600 && this.ActualHeight <= 500)
            {
                Photo_Doctor.Width = 200;
                Photo_Doctor.Height = 200;
            }
            if ((this.ActualWidth >= 1000 && this.ActualHeight >= 700) || this.WindowState == WindowState.Maximized) 
            {
                Photo_Doctor.Width = 400;
                Photo_Doctor.Height = 400;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized) this.WindowState = WindowState.Normal;            
            else this.WindowState = WindowState.Maximized;            
        }
    }
}
