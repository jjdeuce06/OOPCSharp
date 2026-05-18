using System;
namespace OOPAssignment2
{
    public class People
    {
        private string fname;
        private string lname;
        int error;

        public People()
        {
            fname = "blank";
            lname = "blank";
            error = 0;
        }

        public void SetFName(string temp1)
        {
            if (temp1.Length > 0 && temp1.IndexOf(" ") == -1)
            {
                fname = temp1;
            }
            else
            {
                error = 1;
            }
        }

        public void SetLName(string temp2)
        {
            if (temp2.Length > 0 && temp2.IndexOf(" ") == -1)
            {
                lname = temp2;
            }
            else
            {
                error = 1;
            }
        }

        public void SetError(int value)
        {
            error = value;
        }


        public string GetFName()
        {
            return fname;
        }

        public string GetLName()
        {
            return lname;
        }

        public int GetError()
        {
            return error;
        }
    }


}