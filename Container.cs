using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using Newtonsoft.Json;
using System.Collections;
using System.Text.RegularExpressions;

namespace ELM_SET09102
{
    /*
     * Container Pattern handling all the back-end of this project.
     * Last Edited by N. Ivanov on 24.11.2017
     */
    public class Container
    {
        //Making Objects
        Twitter twit = new Twitter();
        SMS sms = new SMS();
        Email em = new Email();
        //That is the list of words used as a hashtag. 
        ArrayList Mentions;
        //Abbreviation lists used to elaborate the meaning of all 
        //the abbreviations in their full meaning, being taken from CSV file. 
        public ArrayList Full_abbr = new ArrayList();
        public ArrayList Final_abbr = new ArrayList();
        /*Dictionary taking 2 arguments used in LoadFromFile method taking
         *the csvfile params. This basically adds items on either {0} or {1}
         * position of the Dictionary depending on Key/Values from a CSV file.
         * First column Abbr is taken as a key and the full explanation as a value.
         */
        static Dictionary<String, String> LoadFromFile(String csvFile)
        {
            var dictionary = new Dictionary<String, String>();
            var lines = File.ReadAllLines(csvFile);
            foreach (var line in lines)
            {
                var fields = line.Split(',', '\r', '\n');
                dictionary[fields[0].Trim()] = fields[1].Trim();
            }
            return dictionary;
        }
        //The replaced value from the CSV file is kept in this string.
        //The method itself explains the logic before.
        static String ReplaceMessage(String message, Dictionary<String, String> dictionary)
        {
            var words = message.Split(' ', ',');
            var s = new StringBuilder();
            foreach (var word in words)
            {
                if (dictionary[word] != null)
                    s.Append(String.Format("{0} <{1}> ", word, dictionary[word]));
                else
                    s.Append(word + " ");     
            }
            return s.ToString().TrimEnd(' ');
        }
        /*Method called upon Saving an SMS.
         *1.Loads the file calling the Load()
         * 2.Key is kept in message which is then used
         * to replace an ABBR with the exact pattern as in eg. AFK <Away From Keyboard>
         * 3.Our new value is added to the full_abbr list.
         * 4.Whole SMS object is written to ELMsms.json file.
         */
        public void Replace_sms()
        {
            var dictionary = LoadFromFile(@"G:\textwords.csv");
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    foreach (string key in dictionary.Keys)
                    {
                        var message = key;
                        if ((window as MainWindow).txtBox_sms_body.Text.Contains(key))
                        {
                            message = ReplaceMessage(message, dictionary);
                            sms.Abbr = message;
                            Full_abbr.Add(sms.Abbr);
                            sms.Abbr_list = Full_abbr;
                        }
                       
                    }
                }
            }
            string content = JsonConvert.SerializeObject(sms);
            File.WriteAllText(@"G:\ELMsms.json", content);
        }
        //Same logic implemented in sms but for a Twitter object.
        public void Replace_twit()
        {
            var dictionary = LoadFromFile(@"G:\textwords.csv");
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    foreach (string key in dictionary.Keys)
                    {
                        var message = key;
                        if ((window as MainWindow).txtBox_twit_body.Text.Contains(key))
                        {
                            message = ReplaceMessage(message, dictionary);
                            twit.Abbr = message;
                            Final_abbr.Add(twit.Abbr);
                            twit.Abbr_list = Final_abbr;
                        }

                    }
                }
            }
            string content = JsonConvert.SerializeObject(twit);
            File.WriteAllText(@"G:\ELMtwit.json", content);
        }
        public void Replace_s_email()
        {
            var dictionary = LoadFromFile(@"G:\textwords.csv");
            foreach (Window window in Application.Current.Windows)
            {

                if (window.GetType() == typeof(MainWindow))
                {
                    foreach(string key in dictionary.Keys)
                    {
                        var message = key;
                        if ((window as MainWindow).txtBox_body.Text.Contains(key))
                        {
                            string textT = em.email_body;
                            string koza = textT.Substring(textT.IndexOf(message) + message.Length+1);

                             message = ReplaceMessage(message,dictionary);
                            em.Abbr = Full_abbr.ToString();
                        }
                    }     
                }
            }
            string content = JsonConvert.SerializeObject(em);
            File.WriteAllText(@"G:\ELM.json", content);
        } 

       //Shows visibility of GUI
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
                    (window as MainWindow).btn_send_email.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_standard_clear.Visibility = Visibility.Visible;
                    (window as MainWindow).cbox_email.Visibility = Visibility.Hidden;
                }
            }
        }
        //Shows visibility of GUI
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
                    (window as MainWindow).btn_send_sir.Visibility = Visibility.Visible;
                    (window as MainWindow).btn_sir_clear.Visibility = Visibility.Visible;
                    (window as MainWindow).cbox_email.Visibility = Visibility.Hidden;
                }
            }
        }
        //Shows visibility of GUI
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
        //Shows visibility of GUI
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
        //Hides content from GUI
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
        //Hides content from GUI
        public void Clear_sir()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).cbox_email.Visibility = Visibility.Hidden;
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
        //Hides content from GUI
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
        /* Metho dgetting a hashtag word in a Twitter Body.
         * Expressions via Regex are used as for getting the word after 
         * a hashtag '#' , Each mach is added to a Mentions list representing
         * and counting people's interests.
         */
        
        public void Get_hashtag()
        {
             Mentions = new ArrayList();
            string hash = twit.Twit_id;
            string text = twit.Twit_body;
            var regex = new Regex(@"(?<=#)\w+");
            var matches = regex.Matches(text);

            foreach (Match m in matches)
            {
                Mentions.Add("ID: " + hash + " " + "Hashtag words #" + m);
            }

        }
        //Assigning Twitter Properties to their input values. Calling methods.
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
                Get_hashtag();
                Replace_twit();
            }
        }
        //Assigning SMS Properties to their input values. Calling methods.
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
            Replace_sms();
            
        }
        //Assigning Standard Email Properties to their input values. Calling methods.
        //Also being called saves all the existing instances of objects in an appropr json file.
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
            void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
            WriteToJsonFile(@"G:\write_email.json", em);
            WriteToJsonFile(@"G:\write_sms.json", sms);
            WriteToJsonFile(@"G:\write_twit.json", twit);
             Save_sir();
            Replace_s_email();  
        }
        //Assigning SIR Properties to their input values. Calling methods.
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
        } // end Save Sir
    } //End Container Class
} //End namespace



