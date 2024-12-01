using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium120";
        public override double halfLife { get; } = 0.492d;
        public override double atomicWeight { get; } = 119.92455d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver120()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.39d, new GammaParticle(52500.0, 0.02362)), new(0.36d, new GammaParticle(68900.0, 0.01799)), new(0.73d, new GammaParticle(89800.0, 0.01381)), new(0.54d, new GammaParticle(101700.0, 0.01219)), new(1.0d, new GammaParticle(158100.0, 0.00784)), new(0.37d, new GammaParticle(595200.0, 0.00208)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver120()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.39d, new GammaParticle(52500.0, 0.02362)), new(0.36d, new GammaParticle(68900.0, 0.01799)), new(0.73d, new GammaParticle(89800.0, 0.01381)), new(0.54d, new GammaParticle(101700.0, 0.01219)), new(1.0d, new GammaParticle(158100.0, 0.00784)), new(0.37d, new GammaParticle(595200.0, 0.00208)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    