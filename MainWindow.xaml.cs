using System.Windows;
using System.Windows.Controls;

namespace ELM_SET09102
{
    /*
     * GUI ELM
     * Last Edited by N. Ivanov on 24.11.2017
     * Methods used for clarity, written with proper names. Not much description here.
     */
    public partial class MainWindow : Window
    {
        Email em = new Email();
        Twitter twit = new Twitter();
        Container cnt= new Container();
        public MainWindow()
        {

            InitializeComponent();
        }
        private void btn_email_Click(object sender, RoutedEventArgs e)
        {
                cbox_email.Visibility = Visibility.Visible;
        }
        
        /* Selected index keeps track of the Check Box selected item.
         * Depending on what user has selected, it will show/ remove
         * content.
         */
        private void cbox_email_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = cbox_email.SelectedIndex;
            
            if (selectedIndex == 0)
                cnt.Show_email0();

            if (selectedIndex == 1)
            {
                MessageBox.Show("IO thing");  // IO r/wr
                cbox_email.Visibility = Visibility.Hidden;
            } 

            if (selectedIndex == 2)
                cnt.Show_email2();
        }

        
        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            //just files here
        }
        //Saves input details of SMS object
        private void btn_sms_Click(object sender, RoutedEventArgs e)
        {
            cnt.Show_sms();  
        }
        //Saves input details of Twitter object
        private void btn_twit_send_Click(object sender, RoutedEventArgs e)
        {
            cnt.Show_twit();    
        }
        //Clears up all gui properties from the window of Standard Email input
        private void btn_standard_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_standard();
        }
        //Clears up all gui properties from the window of SIR report
        private void btn_sir_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_sir();
        }
        //Clears up all gui properties from the window of SMS input
        private void btn_sms_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_sms();
        }
        //Clears up all gui properties from the window of Twit input
        private void btn_twit_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_twit();
        }
        //Sets Twitter properties
        private void btn_sms_send_Click(object sender, RoutedEventArgs e)
        {
            cnt.Save_sms();
        }
        //Sets Standard Email Properties
        private void btn_stand_email_Click(object sender, RoutedEventArgs e)
        {
                cnt.Save_standard_email();
        }
        //Sets SIR p
        private void btn_send_sir_Click(object sender, RoutedEventArgs e)
        {
          //  cnt.Save_sir();
        } 

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
