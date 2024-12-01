using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin122n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin122n";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 121.90641d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin122()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    