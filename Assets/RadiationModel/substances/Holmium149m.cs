using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium149m";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 148.93387d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium149()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.032d, new GammaParticle(94300.0, 0.01315)), new(0.027000000000000003d, new GammaParticle(166100.0, 0.00746)), new(0.253d, new GammaParticle(372100.0, 0.00333)), new(0.038d, new GammaParticle(591700.0, 0.0021)), new(0.055d, new GammaParticle(692900.0, 0.00179)), new(0.015d, new GammaParticle(741000.0, 0.00167)), new(0.997d, new GammaParticle(1034600.0, 0.0012)), new(0.03d, new GammaParticle(1531400.0, 0.00081)), new(0.28d, new GammaParticle(1736400.0, 0.00071)), new(0.19d, new GammaParticle(1754000.0, 0.00071)), new(1.018d, new GammaParticle(511000.0, 0.00243)), new(0.100970376784816d, new GammaParticle(7384.0, 0.16791)), new(0.136489601425078d, new GammaParticle(45207.0, 0.02743)), new(0.2439056494372373d, new GammaParticle(45998.0, 0.02695)), new(0.0783131175187973d, new GammaParticle(52220.0, 0.02374)), new(0.0986745280736846d, new GammaParticle(52791.0, 0.02349)), new(0.0203614105548873d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    