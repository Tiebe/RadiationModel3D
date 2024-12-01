using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium94";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 93.95659d;

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
    