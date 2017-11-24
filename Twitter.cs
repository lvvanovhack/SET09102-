using System;
using System.Collections;

namespace ELM_SET09102
{
    /* Twitter Class containing Twitter ID, Twitter Text and Abbreviations
     * Last Edited by N. Ivanov on 24.11.2017
     */
    public class Twitter
    {
        private string twit_id;
        private string twit_body;
        private string abbr;
        //Same logic as SMS
        public ArrayList Abbr_list { get; set; }
        //Any abbreviations are being kept here.
        public string Abbr
        {
            get { return abbr; }
            set
            {
                abbr = value;
            }
        }
        //A twitter message should not be longer than 140 chars or empty.
        public string Twit_body
        {
            get { return twit_body; }
            set
            {
                if (value.Length > 140)
                    throw new ArgumentException("Max 140");
                else if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                twit_body = value;
            }
        }
        //User's Twitter ID. Should not be empty field.
            public string Twit_id
        {
            get { return twit_id; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Must not be empty");
                twit_id = value;
            }
        }
    } //End of class Twitter
} // End of Namespace