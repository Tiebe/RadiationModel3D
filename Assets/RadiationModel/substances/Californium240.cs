using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium240";
        public override double halfLife { get; } = 57.6d;
        public override double atomicWeight { get; } = 240.06225d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.98d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium236()), new(1.0d, new AlphaParticle(8733002.09)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    