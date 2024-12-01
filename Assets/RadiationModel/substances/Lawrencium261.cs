using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium261";
        public override double halfLife { get; } = 2340.0d;
        public override double atomicWeight { get; } = 261.10688d;

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
    