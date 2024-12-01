using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth186 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth186";
        public override double halfLife { get; } = 0.0148d;
        public override double atomicWeight { get; } = 185.99662d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.955d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium182()), new(1.0d, new AlphaParticle(8779002.09)) } },
            { 0.045d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium186()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0002d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    