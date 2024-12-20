using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium168";
        public override double halfLife { get; } = 8.2d;
        public override double atomicWeight { get; } = 167.94334d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium168()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    