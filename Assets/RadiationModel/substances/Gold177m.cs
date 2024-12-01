using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold177m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold177m";
        public override double halfLife { get; } = 1.193d;
        public override double atomicWeight { get; } = 176.97707d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium173()), new(1.0d, new AlphaParticle(7509002.09)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium177()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    