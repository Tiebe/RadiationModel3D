using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium172m";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 171.93892d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium172()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    