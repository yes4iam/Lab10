using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Angle
    {
        int degree;
        int minute;
        int second;
        
        public bool isCorrect = true;
        public int Degree
        {
            get
            {
                return degree;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    degree = value % 360;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    Degree += value / 60;                    
                    minute = value;
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    Minute += value / 60;
                second = value;
            }
        }
                  
        
        public Angle (int degree, int minute, int second)
        {
            this.Degree = degree;
            this.Minute = minute;
            this.Second = second;                       
        }
                

        public int toRadians()
        {
            return degree/180+minute/(180*60)+second/(180*60*60);
        }
    }
}
