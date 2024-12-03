using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold189 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold189";
        public override double halfLife { get; } = 1722.0d;
        public override double atomicWeight { get; } = 188.96395d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium189()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 3e-07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium185()), new(1.0d, new AlphaParticle(5351002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    