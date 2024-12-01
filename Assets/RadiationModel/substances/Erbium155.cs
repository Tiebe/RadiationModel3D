using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium155";
        public override double halfLife { get; } = 318.0d;
        public override double atomicWeight { get; } = 154.93322d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9997799999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium155()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.00021999999999999998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium151()), new(1.0d, new AlphaParticle(5140002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    