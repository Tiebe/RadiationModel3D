using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium184";
        public override double halfLife { get; } = 10.1d;
        public override double atomicWeight { get; } = 183.98188d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9790000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold184()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.021d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold180()), new(1.0d, new AlphaParticle(7340002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    