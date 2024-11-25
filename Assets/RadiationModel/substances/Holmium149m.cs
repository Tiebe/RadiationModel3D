using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium149m";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 148.93387d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium149() }, { 1.0d, new BetaParticle(1, 4946000.0) }, { 0.032d, new GammaParticle(94300.0, 0.01315) }, { 0.027000000000000003d, new GammaParticle(166100.0, 0.00746) }, { 0.253d, new GammaParticle(372100.0, 0.00333) }, { 0.038d, new GammaParticle(591700.0, 0.0021) }, { 0.055d, new GammaParticle(692900.0, 0.00179) }, { 0.015d, new GammaParticle(741000.0, 0.00167) }, { 0.997d, new GammaParticle(1034600.0, 0.0012) }, { 0.03d, new GammaParticle(1531400.0, 0.00081) }, { 0.28d, new GammaParticle(1736400.0, 0.00071) }, { 0.19d, new GammaParticle(1754000.0, 0.00071) }, { 1.018d, new GammaParticle(511000.0, 0.00243) }, { 0.100970376784816d, new GammaParticle(7384.0, 0.16791) }, { 0.136489601425078d, new GammaParticle(45207.0, 0.02743) }, { 0.2439056494372373d, new GammaParticle(45998.0, 0.02695) }, { 0.0783131175187973d, new GammaParticle(52220.0, 0.02374) }, { 0.0986745280736846d, new GammaParticle(52791.0, 0.02349) }, { 0.0203614105548873d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    