using System;
using System.Collections;

namespace ELM_SET09102
{
    /* SMS Class containing Mobile Number, Body, Full form of Abbreviated words if any
     * Last Edited by N. Ivanov on 24.11.2017
     */
    public class SMS
    {
        private string mob_no;
        private string sms_body;
        private string abbr;
        private SMS myAbbrev;

        public SMS()
        {
        }

        public SMS(SMS myAbbrev)
        {
            this.myAbbrev = myAbbrev;
        }

        public string Abbr
        {
            get { return abbr; }
            set
            {
                abbr = value;
            }
        }
        //This will hold all the abbr in their full form from CSV file
        public ArrayList Abbr_list { get; set; }
        //Mobile number is stored this can't be empty or too long(Invalid Phone No)
        public string Mob_no
        {
            get { return mob_no; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");

                else if(value.Length>10)
                    throw new ArgumentException("Invalid Mobile Number");
                mob_no = value;
            }
        }
        //That's the text message being hold in here. 
        //It should not exceed 140 Chars and not be empty.
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
