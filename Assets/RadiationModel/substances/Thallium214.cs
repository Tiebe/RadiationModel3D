using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium214";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 214.00695d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead214()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead214()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    