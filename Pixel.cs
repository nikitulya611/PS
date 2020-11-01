using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        private double g;
        private double b;

        public Pixel(double _r, double _g, double _b)
        {
            r = g = b = 0;
            R = _r;
            G = _g;
            B = _b;
        }
        
        public static Pixel operator *(Pixel p, double d)
        {
            return new Pixel(Pixel.Trim(p.R * d), Pixel.Trim(p.G * d), Pixel.Trim(p.B * d));
        }

        public static Pixel operator *(double d, Pixel p)
        {
            return new Pixel(Pixel.Trim(p.R * d), Pixel.Trim(p.G * d), Pixel.Trim(p.B * d));
        }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }

        public double R {
            get
            {
                return r;
            } 
            set
            {
                if (value < 0 || value > 1)
                    throw new Exception(string.Format("Wrong channel R value {0} (the value must be between 0 and 1", value));
                r = value;
            }
        }
        public double G {
            get
            {
                return g;
            }
            set
            {
                if (value < 0 || value > 1)
                    throw new Exception(string.Format("Wrong channel G value {0} (the value must be between 0 and 1", value));
                g = value;
            }
        }
        public double B {
            get
            {
                return b;
            }
            set
            {
                if (value < 0 || value > 1)
                    throw new Exception(string.Format("Wrong channel B value {0} (the value must be between 0 and 1", value));
                b = value;
            }
        }   
    }
}
