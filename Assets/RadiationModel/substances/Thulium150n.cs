using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium150n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium150n";
        public override double halfLife { get; } = 0.0052d;
        public override double atomicWeight { get; } = 149.95096d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium150()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    