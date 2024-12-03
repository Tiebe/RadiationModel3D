using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium165n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium165n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 164.93261d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium165()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    