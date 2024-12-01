using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium244";
        public override double halfLife { get; } = 37.0d;
        public override double atomicWeight { get; } = 244.07089d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.96d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium244()) } },
            { 0.04d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium240()), new(1.0d, new AlphaParticle(8967002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    