using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium74m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium74m";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 73.92701d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium74()), new(2.3e-06d, new GammaParticle(3200.0, 0.38745)), new(0.53d, new GammaParticle(56500.0, 0.02194)), new(0.0011d, new GammaParticle(59700.0, 0.02077)), new(0.0046d, new GammaParticle(1127.0, 1.10013)), new(0.04d, new GammaParticle(9225.0, 0.1344)), new(0.08d, new GammaParticle(9252.0, 0.13401)), new(0.017d, new GammaParticle(10306.0, 0.1203)), new(0.017d, new GammaParticle(10313.0, 0.12022)), new(0.0001d, new GammaParticle(10365.0, 0.11962)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium74()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    