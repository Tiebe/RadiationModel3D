using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton68 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton68";
        public override double halfLife { get; } = 0.0216d;
        public override double atomicWeight { get; } = 67.97249d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium68()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium67()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    