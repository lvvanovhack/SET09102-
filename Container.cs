using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ELM_SET09102
{
    public class Container
    {
        //MVVM , x:FieldModifier="public"
        public void Show_email0()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).lbl_email_from_name.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_email_from_email.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_standard.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_heading.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_subj.Visibility = Visibility.Visible; ;
                    (window as MainWindow).lbl_body.Visibility = Visibility.Visible; ;
                    (window as MainWindow).txtBox_sender_email_name.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_sender_email.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_subj.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_body.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_standard_clear.Visibility = Visibility.Visible;
                    (window as MainWindow).cbox_email.Visibility = Visibility.Hidden;
                }
            }
        }

        public void Show_email2()
        { 
         foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).cbox_incident.Visibility = Visibility.Visible;
                    (window as MainWindow).date_sir.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_sc_code.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_sir.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_sir_code.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_incident.Visibility = Visibility.Visible;
                    (window as MainWindow).cbox_incident.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_inc.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_sir_clear.Visibility = Visibility.Visible;
                    (window as MainWindow).cbox_email.Visibility = Visibility.Hidden;
                }
            }
        }

        public void Show_sms()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).lbl_mob_no.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_mob_no.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_sms_body.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_sms_body.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_sms_clear.Visibility = Visibility.Visible;
                }
            }
        }

        public void Show_twit()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).lbl_twit_ID.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_twit_ID.Visibility = Visibility.Visible;
                    (window as MainWindow).lbl_twit_body.Visibility = Visibility.Visible;
                    (window as MainWindow).txtBox_twit_body.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_twit_clear.Visibility = Visibility.Visible;
                }
            }
        }

        public void Clear_standard()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).lbl_email_from_name.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_email_from_email.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_standard.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_heading.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_subj.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_body.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_sender_email_name.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_sender_email.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_subj.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_body.Visibility = Visibility.Hidden;
                    (window as MainWindow).btn_standard_clear.Visibility = Visibility.Hidden;
                }
            }
        }

        public void Clear_sir()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).cbox_incident.Visibility = Visibility.Hidden;
                    (window as MainWindow).date_sir.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_sc_code.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_sir.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_sir_code.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_incident.Visibility = Visibility.Hidden;
                    (window as MainWindow).cbox_incident.Visibility = Visibility.Hidden;
                    (window as MainWindow).btn_inc.Visibility = Visibility.Hidden;
                    (window as MainWindow).btn_sir_clear.Visibility = Visibility.Hidden;
                }
            }
        }

        public void Clear_sms()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).lbl_mob_no.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_mob_no.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_sms_body.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_sms_body.Visibility = Visibility.Hidden;
                    (window as MainWindow).btn_sms_clear.Visibility = Visibility.Hidden;
                }
            }
        }

        public void Clear_twit()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).lbl_twit_ID.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_twit_ID.Visibility = Visibility.Hidden;
                    (window as MainWindow).lbl_twit_body.Visibility = Visibility.Hidden;
                    (window as MainWindow).txtBox_twit_body.Visibility = Visibility.Hidden;
                    (window as MainWindow).btn_twit_clear.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
    

    
