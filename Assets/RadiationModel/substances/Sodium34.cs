using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sodium34 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium34";
        public override double halfLife { get; } = 0.0055d;
        public override double atomicWeight { get; } = 34.03401d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Magnesium34()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Magnesium32()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new NeutronParticle()) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Magnesium34()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    