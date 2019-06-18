using HomeWork23_06_19.Services;
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

namespace HomeWork23_06_19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmailSender _emailSender = new EmailSender();
        private FileDownloader _fileDownloader = new FileDownloader();
        private CatalogMover _catalogMover = new CatalogMover();

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
