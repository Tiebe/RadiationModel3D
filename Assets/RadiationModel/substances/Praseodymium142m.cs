using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium142m";
        public override double halfLife { get; } = 876.0d;
        public override double atomicWeight { get; } = 141.91006d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium142()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    