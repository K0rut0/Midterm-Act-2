namespace trig
{
    public class Trigonometrics
    {
        public double DegToRad(double Angle)
        {
            return (Angle * (Math.PI / 180));
        }
        public double RadToDeg(double Rad)
        {
            double Angle = (Rad * 180)/Math.PI;
            return Angle;
        }
        public double ComputeOppSin()
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            Console.Write("Enter the length of the hypotenuse: ");
            double HypLength = Double.Parse(Console.ReadLine());
            return Math.Sin(Angle) * HypLength;
        }
        public double ComputeOppTan()
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            Console.Write("Enter the length of the adjacent side: ");
            double AdjLength = Double.Parse(Console.ReadLine());
            return Math.Tan(Angle) * AdjLength;
        }
        public double ComputeHypSin()
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            Console.Write("Enter the length of the opposite side: ");
            double OppLength = Double.Parse(Console.ReadLine());
            return OppLength/Math.Sin(Angle);
        }
        public double ComputeHypCos()
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            Console.Write("Enter the length of the adjacent side: ");
            double AdjLength = Double.Parse(Console.ReadLine());
            return AdjLength/Math.Cos(Angle);
        }
        public double ComputeAdjCos()
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            Console.Write("Enter the length of the hypotenuse: ");
            double HypLength = Double.Parse(Console.ReadLine());
            return Math.Cos(Angle) * HypLength;
        }
        public double ComputeAdjTan() 
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            Console.Write("Enter the length of the opposite side: ");
            double OppLength = Double.Parse(Console.ReadLine());
            return OppLength/Math.Tan(Angle);
        }
        public double ComputeAngleSin()
        {
            Console.Write("Enter the length of the opposite side: ");
            double OppLength = Double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the hypotenuse: ");
            double HypLength = Double.Parse(Console.ReadLine());
            return RadToDeg(Math.Asin(OppLength / HypLength));
        }
        public double ComputeAngleCos()
        {
            Console.Write("Enter the length of the adjacent side: ");
            double AdjLength = Double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the hypotenuse: ");
            double HypLength = Double.Parse(Console.ReadLine());
            return RadToDeg(Math.Acos(AdjLength / HypLength));
        }
        public double ComputeAngleTan()
        {
            Console.Write("Enter the length of the opposite side: ");
            double OppLength = Double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the adjacent side: ");
            double AdjLength = Double.Parse(Console.ReadLine());
            return RadToDeg(Math.Atan(OppLength / AdjLength));
        }
        public double ComputeRadSin()
        {
            Console.Write("Enter the length of the opposite side: ");
            double OppLength = Double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the hypotenuse: ");
            double HypLength = Double.Parse(Console.ReadLine());
            double Angle = Math.Asin(OppLength / HypLength);
            return DegToRad(Angle);
        }
        public double PromptDegToRad()
        {
            Console.Write("Enter the angle in degrees: ");
            double Angle = DegToRad(Double.Parse(Console.ReadLine()));
            return Angle;
        }

    }
}