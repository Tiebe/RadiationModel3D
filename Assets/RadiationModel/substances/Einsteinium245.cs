using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium245";
        public override double halfLife { get; } = 66.6d;
        public override double atomicWeight { get; } = 245.0712d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.54d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium241()), new(1.0d, new AlphaParticle(8937002.09)) } },
            { 0.46d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium245()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    