using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel70 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel70";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 69.93643d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper70() }, { 1.0d, new BetaParticle(-1, 1881250.0) }, { 0.04386d, new GammaParticle(78300.0, 0.01583) }, { 0.0051600000000000005d, new GammaParticle(126500.0, 0.0098) }, { 0.004257d, new GammaParticle(127400.0, 0.00973) }, { 0.003741d, new GammaParticle(140400.0, 0.00883) }, { 0.0025800000000000003d, new GammaParticle(232800.0, 0.00533) }, { 0.004644d, new GammaParticle(267800.0, 0.00463) }, { 0.03225d, new GammaParticle(339600.0, 0.00365) }, { 0.02709d, new GammaParticle(377200.0, 0.00329) }, { 0.0025800000000000003d, new GammaParticle(385700.0, 0.00321) }, { 0.012384d, new GammaParticle(385700.0, 0.00321) }, { 0.03483d, new GammaParticle(455100.0, 0.00272) }, { 0.004515d, new GammaParticle(581100.0, 0.00213) }, { 0.01806d, new GammaParticle(618400.0, 0.002) }, { 0.012384d, new GammaParticle(650100.0, 0.00191) }, { 0.013028999999999999d, new GammaParticle(696100.0, 0.00178) }, { 0.003612d, new GammaParticle(956900.0, 0.0013) }, { 0.129d, new GammaParticle(1035600.0, 0.0012) }, { 0.00774d, new GammaParticle(1152300.0, 0.00108) }, { 0.0387d, new GammaParticle(1277600.0, 0.00097) }, { 0.01161d, new GammaParticle(1611200.0, 0.00077) }, { 6.940582196224469e-05d, new GammaParticle(952.0, 1.30236) }, { 0.000661822223060515d, new GammaParticle(8028.0, 0.15444) }, { 0.001289347794779885d, new GammaParticle(8048.0, 0.15406) }, { 0.0002714077494815997d, new GammaParticle(8940.0, 0.13868) }, { 0.0002714077494815997d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    