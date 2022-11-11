using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.ExtensionMethods;

namespace W06.OperatorOverloading
{
    public class ComplexNumber
    {
        public double X { get; set; }  //Real Part
        public double Y { get; set; }  //Imaginary Part

        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.X == c2.X && c1.Y == c2.Y;
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.X != c2.X || c1.Y != c2.Y;
        }

        public static implicit operator string(ComplexNumber c1)
        {
            return $"{c1.X},{c1.Y}";
        }

        public static explicit operator ComplexNumber(string value)
        {
            var c = new ComplexNumber();
            c.X = value.Split(',')[0].ToInt();  //real
            c.Y = value.Split(',')[1].ToInt();  //imaginary 

            return c;
        }


        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                X = c1.X+c2.X,
                Y=c1.Y+c2.Y
            };

        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                X = c1.X - c2.X,
                Y = c1.Y - c2.Y
            };
        }

        public static ComplexNumber operator +(double number, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                X = c2.X +number,
                Y = c2.Y,
            };
        }
        public static ComplexNumber operator +( ComplexNumber c2,double number)
        {
            return new ComplexNumber()
            {
                X = c2.X + number,
                Y = c2.Y,
            };
        }

        public static ComplexNumber operator -(double number, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                X =number- c2.X,
                Y = c2.Y,
            };
        }

        public static ComplexNumber operator -(ComplexNumber c2, double number)
        {
            return new ComplexNumber()
            {
                X = c2.X - number,
                Y = c2.Y,
            };
        }

        public static ComplexNumber operator *(double number, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                X = number * c2.X,
                Y = number * c2.Y,
            };
        }
        public static ComplexNumber operator *(ComplexNumber c2, double number)
        {
            return new ComplexNumber()
            {
                X = number * c2.X,
                Y = number * c2.Y,
            };
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                X =c1.X*c2.X-c1.Y*c2.Y,
                Y = c1.X*c2.Y+c2.X*c1.Y,
            };
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber()
            {
                //X = c1.X * c2.X - c1.Y * c2.Y,
                //Y = c1.X * c2.Y + c2.X * c1.Y,
            };
        }


        public override string ToString()
        {
            var structuredString = "";

            if (this.X == 0 && this.Y == 0)
            {
                structuredString = "0";
            }
            else if (this.X == 0 && this.Y != 0)
            {
                if (this.Y == 1)
                {
                    structuredString = $"i";
                }
                else if (this.Y == -1)
                {
                    structuredString = $"-i";
                }
                else { structuredString = $"{this.Y} i"; }

            }
            else if (this.X != 0 && this.Y == 0)
            {
                structuredString = $"{this.X}";
            }
            else if (this.X != 0 && this.Y != 0)
            {
                var sign = this.Y < 0 ? "-" : "+";

                if (this.Y == 1 || this.Y == -1)
                {
                    structuredString = $"{this.X} {sign} i";
                }
                else if (this.Y < 0)
                {
                    structuredString = $"{this.X} {this.Y}i";
                }
                else
                {
                    structuredString = $"{this.X} {sign} {this.Y}i";
                }
            }

            return structuredString;
        }
    }
}
