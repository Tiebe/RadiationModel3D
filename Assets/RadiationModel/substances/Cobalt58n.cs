using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt58n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 57.93581d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cobalt58()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    