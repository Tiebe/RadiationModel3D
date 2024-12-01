using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium188n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium188n";
        public override double halfLife { get; } = 0.041d;
        public override double atomicWeight { get; } = 187.97634d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium188()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    