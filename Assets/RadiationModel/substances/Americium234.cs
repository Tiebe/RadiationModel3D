using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium234";
        public override double halfLife { get; } = 139.2d;
        public override double atomicWeight { get; } = 234.04773d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium234()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    