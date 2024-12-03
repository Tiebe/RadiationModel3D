using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium90n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90n";
        public override double halfLife { get; } = 18.91d;
        public override double atomicWeight { get; } = 89.91139d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium90()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    