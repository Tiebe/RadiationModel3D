using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium249";
        public override double halfLife { get; } = 123.0d;
        public override double atomicWeight { get; } = 249.07893d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.84d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium249()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.16d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium245()), new(1.0d, new AlphaParticle(8730802.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    