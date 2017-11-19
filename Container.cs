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
        Twitter twit = new Twitter();
        SMS sms = new SMS();
        Email em = new Email();

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
                    (window as MainWindow).btn_sms_send.Visibility = Visibility.Visible;
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
                    (window as MainWindow).btn_twit_send.Visibility = Visibility.Visible;
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
        
        public void Save_twit()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    try
                    {
                        twit.Twit_id = (window as MainWindow).txtBox_twit_ID.Text;
                        twit.Twit_body = (window as MainWindow).txtBox_twit_body.Text;
                        (window as MainWindow).btn_twit_send.Visibility = Visibility.Hidden;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void Save_sms()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    try
                    {
                        sms.Mob_no = (window as MainWindow).txtBox_mob_no.Text;
                        sms.SMS_body = (window as MainWindow).txtBox_sms_body.Text;
                        (window as MainWindow).btn_sms_send.Visibility = Visibility.Hidden;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void Save_standard_email()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    try
                    {
                        em.P_name = (window as MainWindow).txtBox_sender_email_name.Text;
                        em.P_email = (window as MainWindow).txtBox_sender_email.Text;
                        em.Subj = (window as MainWindow).txtBox_subj.Text;
                        em.Email_body = (window as MainWindow).txtBox_body.Text;
                        (window as MainWindow).btn_send_email.Visibility = Visibility.Hidden;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void Save_sir()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    try
                    {
                        em.Sir_code = (window as MainWindow).txtBox_sir_code.Text;
                        em.Incident = (window as MainWindow).cbox_incident.SelectedValue.ToString();
                        em.Sir_d = (DateTime)(window as MainWindow).date_sir.SelectedDate;
                        (window as MainWindow).btn_send_sir.Visibility = Visibility.Hidden;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
    

    
