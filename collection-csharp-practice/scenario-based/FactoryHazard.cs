using System;
class HazardFactory
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Choose armPrecision between 0.0-1.0 ");
            double armPrecision = double.Parse(Console.ReadLine());

            if (armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
            }
            Console.WriteLine("Choose workerDensity between 1-20 ");
            int workerDensity = int.Parse(Console.ReadLine());
            if (workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error:Worker density must be 1-20");
            }
            Console.WriteLine("Choose Machine State : Worn/Faulty/Critical ");
            string machineryState = Console.ReadLine();
            if (!(machineryState.Equals("Worn") || machineryState.Equals("Faulty") || machineryState.Equals("Critical")))
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }
            double HazardRisk = CalculateHazardRisk(armPrecision, workerDensity, machineryState);
            Console.WriteLine("Hazard risk score : " + HazardRisk);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public static double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        switch (machineryState)
        {
            case "Worn": return (1.0 - armPrecision) * 15.0 + (workerDensity * 1.3);

            case "Faulty": return (1.0 - armPrecision) * 15.0 + (workerDensity * 2.0);

            default: return (1.0 - armPrecision) * 15.0 + (workerDensity * 3.0);
        }

    }
}
class RobotSafetyException : Exception
{
    public RobotSafetyException(string s) : base(s) { }
}