using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury178 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury178";
        public override double halfLife { get; } = 0.2665d;
        public override double atomicWeight { get; } = 177.98249d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum174()), new(1.0d, new AlphaParticle(7600002.09)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum178()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    