using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine94 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine94";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 93.94885d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton94()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.68d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton94()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    