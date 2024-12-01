using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium240";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 240.06895d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium236()), new(1.0d, new AlphaParticle(9287002.09)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium240()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.048d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium240()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    