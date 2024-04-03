// See https://aka.ms/new-console-template for more information
using trig;

Trigonometrics TriManager = new Trigonometrics();

int st = 0;
while (st == 0)
{
    Console.WriteLine(
        "[1] Compute the opposite side using Sine\n[2] Compute the opposite side using Tan\n" +
        "[3] Compute Hypotenuse using Sine\n[4] Compute Hypotenuse using Cosine\n" +
        "[5] Compute adjacent side using Cosine\n[6] Compute adjacent side using Tan\n" +
        "[7] Compute angle using sine\n[8] Compute angle using cos\n[9] Compute angle using tan\n" +
        "[0] Compute radians based on opposite side and hypotenuse\n" +
        "[11] Compute radians based on angle\n" +
        "[12] Exit"
        );
    Console.Write("Enter opperation: ");
    int n = int.Parse( Console.ReadLine() );
    switch (n)
    {
        case 1:
            Console.WriteLine("Output = " + TriManager.ComputeOppSin());
            break;
        case 2:
            Console.WriteLine("Output = " + TriManager.ComputeOppTan());
            break;
        case 3:
            Console.WriteLine("Output = " + TriManager.ComputeHypSin());
            break;
        case 4:
            Console.WriteLine("Output = " + TriManager.ComputeHypCos());
            break;
        case 5:
            Console.WriteLine("Output = " + TriManager.ComputeAdjCos());
            break;
        case 6:
            Console.WriteLine("Output = " + TriManager.ComputeAdjTan());
            break;
        case 7:
            Console.WriteLine("Output = " + TriManager.ComputeAngleSin());
            break;
        case 8:
            Console.WriteLine("Output = " + TriManager.ComputeAngleCos());
            break;
        case 9:
            Console.WriteLine("Output = " + TriManager.ComputeAngleTan());
            break;
        case 0:
            Console.WriteLine("Output = " + TriManager.ComputeRadSin());
            break;
        case 11:
            Console.WriteLine("Output = " + TriManager.PromptDegToRad());
            break;
        case 12:
            st++;
            break;

    }
        
}
