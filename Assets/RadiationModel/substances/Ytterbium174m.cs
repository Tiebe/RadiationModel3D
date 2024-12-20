using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium174m";
        public override double halfLife { get; } = 0.00083d;
        public override double atomicWeight { get; } = 173.9405d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium174()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    