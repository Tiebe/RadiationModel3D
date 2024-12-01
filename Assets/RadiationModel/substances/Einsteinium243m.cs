using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium243m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium243m";
        public override double halfLife { get; } = 21.0d;
        public override double atomicWeight { get; } = 243.06957d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.61d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium239()), new(1.0d, new AlphaParticle(9147002.09)) } },
            { 0.39d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium243()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    