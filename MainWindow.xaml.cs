using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ELM_SET09102
{
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
        
        private void cbox_email_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = cbox_email.SelectedIndex;
         //   Object selectedItem = cbox_email.SelectedItem;
            
            if (selectedIndex == 0)
            {
                cnt.Show_email0();
             //   btn_standard_clear.Visibility = Visibility.Visible;
             //   cbox_email.Visibility = Visibility.Hidden;
            }

            if (selectedIndex == 1)
            {
                MessageBox.Show("IO thing");  // IO r/wr
                cbox_email.Visibility = Visibility.Hidden;
            } 

            if (selectedIndex == 2)
            {
                cnt.Show_email2();
             //   btn_sir_clear.Visibility = Visibility.Visible;
               // cbox_email.Visibility = Visibility.Hidden;
            }

        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_sms_Click(object sender, RoutedEventArgs e)
        {
            cnt.Show_sms();  
        }

        private void btn_twitter_Click(object sender, RoutedEventArgs e)
        {
            cnt.Show_twit();    
        }

        private void cbox_incident_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

         em.Incident = cbox_incident.SelectedValue.ToString();
         MessageBox.Show(em.Incident);
        }

        private void btn_standard_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_standard();
        }

        private void btn_sir_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_sir();
        }

        private void btn_sms_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_sms();
        }

        private void btn_twit_clear_Click(object sender, RoutedEventArgs e)
        {
            cnt.Clear_twit();
        }

        private void btn_twit_send_Click(object sender, RoutedEventArgs e)
        {
                cnt.Save_twit();
        }

        private void btn_sms_send_Click(object sender, RoutedEventArgs e)
        {
            cnt.Save_sms();
        }

        private void btn_stand_email_Click(object sender, RoutedEventArgs e)
        {
            cnt.Save_standard_email();
        }

        private void btn_send_sir_Click(object sender, RoutedEventArgs e)
        {
            cnt.Save_sir();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
