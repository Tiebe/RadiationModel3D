using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton67 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton67";
        public override double halfLife { get; } = 0.0074d;
        public override double atomicWeight { get; } = 66.98331d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.63d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium67()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.37d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium65()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    