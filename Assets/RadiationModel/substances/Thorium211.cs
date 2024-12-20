using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium211";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 211.0149d;

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
    