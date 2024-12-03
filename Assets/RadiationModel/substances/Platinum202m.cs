using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum202m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum202m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 201.97756d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum202()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    