using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium242";
        public override double halfLife { get; } = 17.8d;
        public override double atomicWeight { get; } = 242.06957d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.57d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium238()), new(1.0d, new AlphaParticle(9177002.09)) } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium242()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    