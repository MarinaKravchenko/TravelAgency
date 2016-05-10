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

namespace TravelAgency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UIElement[] members;
        List<string> countries;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            stackPanel.Children.Clear();

            TextBlock space = new TextBlock();
            space.Margin = new Thickness(40);
            TextBlock block = new TextBlock();
            block.Text = "Номер паспорта:";
            block.FontSize = 16;
            block.HorizontalAlignment = HorizontalAlignment.Center;
            block.Margin = new Thickness(10);
            TextBox box = new TextBox();
            box.Width = 200;
            box.HorizontalAlignment = HorizontalAlignment.Center;
            Button button = new Button();
            button.Content = "Войти";
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.Margin = new Thickness(10);
            button.Width = 100;
            button.Click += button_SignIn_Final_Click;
            
            stackPanel.Children.Add(space);
            stackPanel.Children.Add(block);
            stackPanel.Children.Add(box);
            stackPanel.Children.Add(button);
        }

        private void button_SignIn_Final_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_SignUp_Click(object sender, RoutedEventArgs e)
        {
            stackPanel.Children.Clear();

            TextBlock block1 = new TextBlock()
            {
                Text = "   Номер паспорта:",
                FontSize = 16,
                Margin = new Thickness(0, 10, 0, 0)
            };
            TextBox box1 = new TextBox()
            {
                Name = "passport",
                Width = 200
            };

            TextBlock block2 = new TextBlock()
            {
                Text = "   Фамилия:",
                FontSize = 16
            };
            TextBox box2 = new TextBox()
            {
                Name = "lastName",
                Width = 200
            };

            TextBlock block3 = new TextBlock()
            {
                Text = "   Имя:",
                FontSize = 16
            };
            TextBox box3 = new TextBox()
            {
                Name = "firstName",
                Width = 200
            };

            TextBlock block4 = new TextBlock()
            {
                Text = "   Отчество:",
                FontSize = 16
            };
            TextBox box4 = new TextBox();
            box4.Name = "middleName";
            box4.Width = 200;

            TextBlock block5 = new TextBlock()
            {
                Text = "   Телефон:",
                FontSize = 16
            };            
            TextBox box5 = new TextBox();
            box5.Name = "phone";
            box5.Width = 200;

            Button button = new Button()
            {
                Content = "Зарегистрироваться",
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(10),
                Width = 150
            };            
            button.Click += button_SignUp_Final_Click;
            
            stackPanel.Children.Add(block1);
            stackPanel.Children.Add(box1);
            stackPanel.Children.Add(block2);
            stackPanel.Children.Add(box2);
            stackPanel.Children.Add(block3);
            stackPanel.Children.Add(box3);
            stackPanel.Children.Add(block4);
            stackPanel.Children.Add(box4);
            stackPanel.Children.Add(block5);
            stackPanel.Children.Add(box5);
            stackPanel.Children.Add(button);
            members = new UIElement[stackPanel.Children.Count];
            stackPanel.Children.CopyTo(members, 0);
        }

        private void button_SignUp_Final_Click(object sender, RoutedEventArgs e)
        {/*
            stackPanel.Children.Clear();
            stackPanel.Children.Add(members[1]);
            TextBox t = (TextBox)members[1];
            TextBlock tx = new TextBlock();
            tx.Text = t.Text;
            stackPanel.Children.Add(tx);*/

            stackPanel.Children.Clear();

            TextBlock space = new TextBlock();
            space.Margin = new Thickness(30);

            TextBlock block = new TextBlock()
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(10),
                FontSize = 16,
                Text = "Путевки"   
            };
            Button button1 = new Button()
            {
                Width = 200,
                Margin = new Thickness(5),
                Content = "Посмотреть существующие"
            };
            Button button2 = new Button()
            {
                Width = 200,
                Margin = new Thickness(5),
                Content = "Создать новую путевку"
            };
            stackPanel.Children.Add(space);
            stackPanel.Children.Add(block);
            stackPanel.Children.Add(button1);
            stackPanel.Children.Add(button2);
            button1.Click += Button_History_Click;
            button2.Click += Button_Create_Click;
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            countries = new List<string>();
            countries.Add("Россия");
            countries.Add("Англия");
            countries.Add("Греция");
            countries.Add("Кипр");

            stackPanel.Children.Clear();

            TextBlock block1 = new TextBlock()
            {
                Text = "   Страна:",
                FontSize = 16,
                Margin = new Thickness(0, 10, 0, 0)
            };
            ComboBox combo1 = new ComboBox()
            {
                Width = 100,
                ItemsSource = countries,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            TextBlock block3 = new TextBlock()
            {
                Text = "   Дата:",
                FontSize = 16
            };
            DatePicker date = new DatePicker()
            {
                HorizontalAlignment = HorizontalAlignment.Center
            };

            TextBlock block2 = new TextBlock()
            {
                Text = "   Номер рейса:",
                FontSize = 16
            };
            ComboBox combo2 = new ComboBox()
            {
                Width = 100,
                ItemsSource = countries,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            TextBlock block4 = new TextBlock()
            {
                Text = "   Отель:",
                FontSize = 16
            };
            ComboBox combo4 = new ComboBox()
            {
                Width = 100,
                ItemsSource = countries,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            TextBlock block5 = new TextBlock()
            {
                Text = "   Номер:",
                FontSize = 16
            };
            ComboBox combo5 = new ComboBox()
            {
                Width = 100,
                ItemsSource = countries,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            Button button1 = new Button()
            {
                Width = 100,
                Margin = new Thickness(10),
                Content = "Добавить",
                HorizontalAlignment = HorizontalAlignment.Right
            };

            stackPanel.Children.Add(block1);
            stackPanel.Children.Add(combo1);
            stackPanel.Children.Add(block3);
            stackPanel.Children.Add(date);
            stackPanel.Children.Add(block2);
            stackPanel.Children.Add(combo2);
            stackPanel.Children.Add(block4);
            stackPanel.Children.Add(combo4);
            stackPanel.Children.Add(block5);
            stackPanel.Children.Add(combo5);
            stackPanel.Children.Add(button1);
            members = new UIElement[stackPanel.Children.Count];
            stackPanel.Children.CopyTo(members, 0);
        }

        private void Button_History_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
