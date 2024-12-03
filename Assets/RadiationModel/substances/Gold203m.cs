using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold203m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold203m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 202.97584d;

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
    