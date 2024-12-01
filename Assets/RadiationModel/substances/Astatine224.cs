using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine224 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine224";
        public override double halfLife { get; } = 78.0d;
        public override double atomicWeight { get; } = 224.02975d;

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
    