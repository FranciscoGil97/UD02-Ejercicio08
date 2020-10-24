using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UD02_Ejercicio08
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = avisoNombreTextBlock;
            apellidoTextBox.Tag = avisoApellidoTextBlock;
            edadTextBox.Tag = avisoEdadTextBlock;
        }

        private void NombreApellidoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                ((sender as TextBox).Tag as TextBlock).Visibility = 
                    (((sender as TextBox).Tag as TextBlock).Visibility == Visibility.Hidden?  
                                                                                Visibility.Visible :
                                                                                Visibility.Hidden);
        }

        private void EdadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
                ((sender as TextBox).Tag as TextBlock).Visibility = 
                                                    int.TryParse(edadTextBox.Text, out _) ? 
                                                        Visibility.Hidden : 
                                                        Visibility.Visible;
        }
    }
}
