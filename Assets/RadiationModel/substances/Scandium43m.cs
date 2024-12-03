using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium43m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium43m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 42.96131d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium43()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    