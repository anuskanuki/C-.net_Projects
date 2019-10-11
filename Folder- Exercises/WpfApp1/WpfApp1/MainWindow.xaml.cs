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

namespace WpfApp1
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
        List<Teste> novaLista = new List<Teste>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            novaLista.Add(new Teste() { Id = 0,Name = "Felipe" }) ;
            novaLista.Add(new Teste() { Id = 0, Name = "Felipe" });
            novaLista.Add(new Teste() { Id = 0, Name = "Felipe" });

            Grid.ItemsSource = novaLista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Teste
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
