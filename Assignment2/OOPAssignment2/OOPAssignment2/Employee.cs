using System;

namespace OOPAssignment2
{
    public class Employee : People
    {
        private float hourlyrate;
        private float hoursworked;
        private float grosspay;

        public Employee()
        {
            hourlyrate = 0;
            hoursworked = 0;
            grosspay = 0;
            SetError(0);
        }

        public void SetHourlyRate(float temp)
        {
            if (temp >= 8.25)
            {
                hourlyrate = temp;
            }
            else
            {
                SetError(1);
            }
        }

        public void SetHoursWorked(float temp)
        {
            if (temp >= 0)
            {
                hoursworked = temp;
            }
            else
            {
                SetError(1);
            }
        }

        public void SetGrossPay(float rate, float work)
        {
            if (work >= 0 && rate >= 8.25)
            {
                if (work > 40)
                {
                    grosspay = ((rate * 40) + ((work - 40) * (rate * 1.5f)));
                }
                else
                {
                    grosspay = work * rate;
                }
            }
            else
            {
                SetError(1);
            }
        }

        public float GetHourlyRate()
        {
            return hourlyrate;
        }

        public float GetGrossPay()
        {
            return grosspay;
        }

        public float GetHoursWorked()
        {
            return hoursworked;
        }

        public void DisplayEmployee()
        {
            if (GetError() == 0)
            {
                string fullName = GetLName() + ", " + GetFName();
                Console.WriteLine(fullName + ": " + grosspay);
            }
            else
            {
                Console.WriteLine("This record contains bad data, cannot process");
            }
        }
    }

}
