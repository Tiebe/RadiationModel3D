using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium240";
        public override double halfLife { get; } = 288.0d;
        public override double atomicWeight { get; } = 240.05975d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 2e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium240()) } },
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
    