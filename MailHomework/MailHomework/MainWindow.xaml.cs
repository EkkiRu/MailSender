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
using System.Net.Mail;
using System.Net;

namespace MailHomework
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

        private void Send(object sender, RoutedEventArgs e)
        {
            var postClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 465,
                EnableSsl = true,
                Credentials = new NetworkCredential("rukzwolf@gmail.com", "")
            };

            var mail = new MailMessage("rukzwolf@gmail.com", Mail.Text, Theme.Text, TextMessage.Text);

            //mail.Attachments.Add(new Attachment());

            postClient.Send(mail);
        }
    }
}
