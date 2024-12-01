using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sulfur44 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur44";
        public override double halfLife { get; } = 0.117d;
        public override double atomicWeight { get; } = 43.99012d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine44()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.013999999999999999d, new GammaParticle(891000.0, 0.00139)), new(0.036000000000000004d, new GammaParticle(1000000.0, 0.00124)), new(0.41d, new GammaParticle(2789000.0, 0.00044)) } },
            { 0.29d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine44()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.013999999999999999d, new GammaParticle(891000.0, 0.00139)), new(0.036000000000000004d, new GammaParticle(1000000.0, 0.00124)), new(0.41d, new GammaParticle(2789000.0, 0.00044)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    