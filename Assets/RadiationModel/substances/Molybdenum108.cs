using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum108 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum108";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 107.92405d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium108() }, { 1.0d, new BetaParticle(-1, 2587000.0) }, { 0.03526d, new GammaParticle(28000.0, 0.04428) }, { 0.0387d, new GammaParticle(58400.0, 0.02123) }, { 0.0559d, new GammaParticle(65700.0, 0.01887) }, { 0.041710000000000004d, new GammaParticle(67800.0, 0.01829) }, { 0.0774d, new GammaParticle(86400.0, 0.01435) }, { 0.03569d, new GammaParticle(106200.0, 0.01167) }, { 0.02709d, new GammaParticle(118400.0, 0.01047) }, { 0.0086d, new GammaParticle(161800.0, 0.00766) }, { 0.0645d, new GammaParticle(190500.0, 0.00651) }, { 0.02795d, new GammaParticle(223300.0, 0.00555) }, { 0.0129d, new GammaParticle(228200.0, 0.00543) }, { 0.1118d, new GammaParticle(240500.0, 0.00516) }, { 0.00817d, new GammaParticle(254200.0, 0.00488) }, { 0.2236d, new GammaParticle(268300.0, 0.00462) }, { 0.03569d, new GammaParticle(295600.0, 0.00419) }, { 0.00731d, new GammaParticle(299600.0, 0.00414) }, { 0.01849d, new GammaParticle(312200.0, 0.00397) }, { 0.0086d, new GammaParticle(334600.0, 0.00371) }, { 0.0473d, new GammaParticle(340300.0, 0.00364) }, { 0.1032d, new GammaParticle(372400.0, 0.00333) }, { 0.0688d, new GammaParticle(391000.0, 0.00317) }, { 0.0086d, new GammaParticle(430800.0, 0.00288) }, { 0.01978d, new GammaParticle(458500.0, 0.0027) }, { 0.03483d, new GammaParticle(477500.0, 0.0026) }, { 0.01075d, new GammaParticle(535800.0, 0.00231) }, { 0.01892d, new GammaParticle(570100.0, 0.00217) }, { 0.02365d, new GammaParticle(635800.0, 0.00195) }, { 0.03252958029777d, new GammaParticle(2586.0, 0.47944) }, { 0.1403844091911178d, new GammaParticle(18250.0, 0.06794) }, { 0.2669412610593607d, new GammaParticle(18367.0, 0.0675) }, { 0.07094783047454363d, new GammaParticle(20695.0, 0.05991) }, { 0.08215758768952151d, new GammaParticle(20820.0, 0.05955) }, { 0.011209757214977894d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    