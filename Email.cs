using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ELM_SET09102
{
    public class Email
    {
        private string subj;
        private string email_body;
        private string p_name;
        private string p_email;
        private string sir_code;
        private DateTime sir_d;

        public DateTime Sir_d
        {
            get { return sir_d; }
            set
            {
                sir_d = value;
            }
        }

        public string P_name
        {
            get { return p_name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                p_name = value;
            }
        }
        public string P_email
        {
            get { return p_email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                p_email = value;
            }
        }
        public string Subj
        {
            get { return subj; }         
            set
            {
                if (value.Length > 20)
                    throw new ArgumentException("Max 20");
                else if(String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                subj = value;   
            }
        }
        public string Email_body
        {
            get { return email_body; }
            set
            {
                if (value.Length > 1028)
                    throw new ArgumentException("Max 140");
                else if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                email_body = value;
            }
        }
        public string Incident { get; set; }

        public string Sir_code
        {
            get { return sir_code; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                else if(!System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-zA-Z]"))
                    throw new ArgumentException("Accepts only alphabetical characters!");
                sir_code = value;
            }
        }
        /*
            inci.Add("Theft of Properties");
            inci.Add("Staff Attack");
            inci.Add("Device Damage");
            inci.Add("Raid");
            inci.Add("Customer Attack");
            inci.Add("Staff Abuse");
            inci.Add("Bomb Threat");
            inci.Add("Terrorism");
            inci.Add("Suspicious Incident");
            inci.Add("Sport Injury");
            inci.Add("Personal Info Leak");
        */
    }

        


} 

