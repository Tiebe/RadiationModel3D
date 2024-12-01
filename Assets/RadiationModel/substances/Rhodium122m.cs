using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium122m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium122m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 121.94459d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium122()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    