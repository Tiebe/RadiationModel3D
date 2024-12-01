using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine199 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine199";
        public override double halfLife { get; } = 7.03d;
        public override double atomicWeight { get; } = 198.99053d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth195()), new(1.0d, new AlphaParticle(7800002.09)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth199()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    