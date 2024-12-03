using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium187m";
        public override double halfLife { get; } = 0.0303d;
        public override double atomicWeight { get; } = 186.95774d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium187()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    