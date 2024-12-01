using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine110 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine110";
        public override double halfLife { get; } = 0.664d;
        public override double atomicWeight { get; } = 109.93508d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.83d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony110()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.17d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony106()), new(1.0d, new AlphaParticle(4600002.09)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony109()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    