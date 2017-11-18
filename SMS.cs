using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELM_SET09102
{
    public class SMS
    {
        private string mob_no;
        private string sms_body;
        public string Mob_no
        {
            get { return mob_no; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                else if (!System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-zA-Z]"))
                    throw new ArgumentException("Accepts only alphabetical characters!");
                else if(mob_no.Length>10)
                    throw new ArgumentException("Invalid Mobile Number");
                mob_no = value;
            }
        }
        public string SMS_body
        {
            get { return sms_body; }
            set
            {
                if (value.Length > 140)
                    throw new ArgumentException("Max 140");
                else if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                sms_body = value;
            }
        }
    } // End of class SMS
} //End of namespeace
