using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium133m";
        public override double halfLife { get; } = 70.0d;
        public override double atomicWeight { get; } = 132.92249d;

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
    