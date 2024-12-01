using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin124p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin124p";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 123.90813d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin124()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    