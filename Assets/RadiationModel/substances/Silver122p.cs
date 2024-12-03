using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver122p : RadioactiveSubstance
    {
        public override string name { get; } = "Silver122p";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 121.92384d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    