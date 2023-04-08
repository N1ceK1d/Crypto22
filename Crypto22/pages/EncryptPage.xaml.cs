using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Crypto22.pages
{
    /// <summary>
    /// Логика взаимодействия для EncryptPage.xaml
    /// </summary>
    public partial class EncryptPage : Page
    {
        public EncryptPage()
        {
            InitializeComponent();
            Collection<string> ciphers = new Collection<string> {"AES", "DES", "BlowFish", "RC2", "Rijndael", "TripleDES"};
            CipherSelecter.ItemsSource = ciphers;
        }

        private void EncryptBtn_Click(object sender, RoutedEventArgs e)
        {
            resultText.Text = AesCipher.EncryptAES(textMessage.Text);
        }
    }
}
