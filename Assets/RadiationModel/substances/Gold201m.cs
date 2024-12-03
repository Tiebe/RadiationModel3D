using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold201m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201m";
        public override double halfLife { get; } = 0.00034d;
        public override double atomicWeight { get; } = 200.9723d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    