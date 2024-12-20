using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium102";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 101.96001d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium102()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.18d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium102()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    