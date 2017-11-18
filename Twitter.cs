using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELM_SET09102
{
    public class Twitter
    {
        private string twit_id;
        private string twit_body;
        private DateTime sir_d;

        public DateTime Sir_d
        {
            get { return sir_d; }
            set
            {
               sir_d = value;
            }
        }
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