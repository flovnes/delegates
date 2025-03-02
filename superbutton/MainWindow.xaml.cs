using System;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace superbuttonLab;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click_Color(object sender, RoutedEventArgs e)
    {
        Background = Background == Brushes.CornflowerBlue ? Brushes.CadetBlue : Brushes.CornflowerBlue;
    }

    private void Button_Click_Opacity(object sender, RoutedEventArgs e)
    {
        Opacity += Opacity > 0.9 ? -0.1 : 0.1;
    }

    private void Button_Click_Hello(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Вам вручено \"Привіт\".", "Повідомлення", 0, MessageBoxImage.Warning, 0, MessageBoxOptions.DefaultDesktopOnly);
    }

    private void CheckBox_Click_Color(object sender, RoutedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.IsChecked == true)
                superButton.Click += Button_Click_Color;
            else
                superButton.Click -= Button_Click_Color;
        }
    }

    private void CheckBox_Click_Opacity(object sender, RoutedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.IsChecked == true)
                superButton.Click += Button_Click_Opacity;
            else
                superButton.Click -= Button_Click_Opacity;
        }
    }

    private void CheckBox_Click_Hello(object sender, RoutedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.IsChecked == true)
                superButton.Click += Button_Click_Hello;
            else
                superButton.Click -= Button_Click_Hello;
        }
    }

    private void Button_Click_Super(object sender, RoutedEventArgs e)
    {
		MessageBox.Show("Я суперкнопка,\nі мене цього не позбавиш!");
    }

    private void DragBar_MouseDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void Button_CloseWindow(object sender, RoutedEventArgs e)
    {
        Close();
    }
}