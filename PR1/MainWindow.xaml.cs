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

namespace PR1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                
                Grid matrixGrid = new Grid();
                matrixGrid.ShowGridLines = true;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Button button = new Button();
                        button.Content = $"[{i},{j}]";
                        button.Margin = new Thickness(5);

                        Grid.SetRow(button, i);
                        Grid.SetColumn(button, j);
                        matrixGrid.Children.Add(button);
                    }
                }
                matrixGrid.RowDefinitions.Add(new RowDefinition());
                matrixGrid.RowDefinitions.Add(new RowDefinition());
                matrixGrid.RowDefinitions.Add(new RowDefinition());

                matrixGrid.ColumnDefinitions.Add(new ColumnDefinition());
                matrixGrid.ColumnDefinitions.Add(new ColumnDefinition());
                matrixGrid.ColumnDefinitions.Add(new ColumnDefinition());
                
                MainGrid.Children.Add(matrixGrid);
            }
        }
    }

   
