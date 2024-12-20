using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold180 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold180";
        public override double halfLife { get; } = 8.4d;
        public override double atomicWeight { get; } = 179.97249d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.982d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium180()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.018000000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium176()), new(1.0d, new AlphaParticle(6853002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    