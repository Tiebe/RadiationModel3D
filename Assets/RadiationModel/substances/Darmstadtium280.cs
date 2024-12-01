using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Darmstadtium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium280";
        public override double halfLife { get; } = 0.007d;
        public override double atomicWeight { get; } = 280.16138d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
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
    