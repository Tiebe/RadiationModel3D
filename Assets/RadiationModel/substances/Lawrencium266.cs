using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium266";
        public override double halfLife { get; } = 39600.0d;
        public override double atomicWeight { get; } = 266.11987d;

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
    