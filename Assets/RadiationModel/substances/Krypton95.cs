using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton95 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton95";
        public override double halfLife { get; } = 0.114d;
        public override double atomicWeight { get; } = 94.93971d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium95()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0287d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium95()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    