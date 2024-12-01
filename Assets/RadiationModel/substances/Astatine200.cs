using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine200 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200";
        public override double halfLife { get; } = 43.1d;
        public override double atomicWeight { get; } = 199.99035d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.52d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth196()), new(1.0d, new AlphaParticle(7618002.09)) } },
            { 0.48d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth200()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    