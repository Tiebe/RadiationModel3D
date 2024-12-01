using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium128";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 127.94823d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium128()) } },
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
    