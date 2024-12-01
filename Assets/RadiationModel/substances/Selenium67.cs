using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium67";
        public override double halfLife { get; } = 0.133d;
        public override double atomicWeight { get; } = 66.94999d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium67()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium66()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    