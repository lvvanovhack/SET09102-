using System;
using System.Collections;

namespace ELM_SET09102
{
    /* Twitter Class containing 2 types. Standard Email and Incident Reports (SIR),
     * A Standard Email needs: Name, Subject, Personal Email, Body and Abbr.
     * SIR reports include SIR Code and A Date. Incident is at checkbox
     * selectedItem property.
     * Last Edited by N. Ivanov on 24.11.2017
     */
    public class Email
    {
        private string subj;
        public string email_body;
        private string p_name;
        private string p_email;
        private string sir_code;
        private DateTime sir_d;
        private string abbr;
        //Same logic as before
        public string Abbr
        {
            get { return abbr; }
            set
            {
                abbr = value;
            }
        }
        //Date is stored as dd/MM/yyyy
        public DateTime Sir_d
        {
            get { return sir_d; }
            set
            {
                sir_d = value;
            }
        }
        //Person's name (Sender Name). Not empty.
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
        //Personal Email. Not Empty.
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
        //The Email Subject should not exceed 20 Chars or be empty.
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
        //Email Body can't exceed 140 characters.
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
        //Property of the incident/reason.
        public string Incident { get; set; }
        //SIR code 
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
    }
} 

