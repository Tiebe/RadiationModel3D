using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium159";
        public override double halfLife { get; } = 12.1d;
        public override double atomicWeight { get; } = 158.94663d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium159()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium155()), new(1.0d, new AlphaParticle(5513002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    