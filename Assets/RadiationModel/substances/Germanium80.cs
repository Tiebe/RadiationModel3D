using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium80";
        public override double halfLife { get; } = 29.5d;
        public override double atomicWeight { get; } = 79.92535d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic80() }, { 1.0d, new BetaParticle(-1, 1339850.0) }, { 0.06480000000000001d, new GammaParticle(110400.0, 0.01123) }, { 0.27d, new GammaParticle(265360.0, 0.00467) }, { 0.01269d, new GammaParticle(310720.0, 0.00399) }, { 0.004509d, new GammaParticle(319450.0, 0.00388) }, { 0.008100000000000001d, new GammaParticle(360870.0, 0.00344) }, { 0.005967d, new GammaParticle(369670.0, 0.00335) }, { 0.0034289999999999998d, new GammaParticle(414920.0, 0.00299) }, { 0.0036720000000000004d, new GammaParticle(576270.0, 0.00215) }, { 0.008369999999999999d, new GammaParticle(626450.0, 0.00198) }, { 0.02214d, new GammaParticle(680160.0, 0.00182) }, { 0.008100000000000001d, new GammaParticle(782300.0, 0.00158) }, { 0.0405d, new GammaParticle(936970.0, 0.00132) }, { 0.027000000000000003d, new GammaParticle(1014000.0, 0.00122) }, { 0.02835d, new GammaParticle(1116000.0, 0.00111) }, { 0.03375d, new GammaParticle(1256100.0, 0.00099) }, { 0.048600000000000004d, new GammaParticle(1564300.0, 0.00079) }, { 0.0014039999999999999d, new GammaParticle(1873100.0, 0.00066) } } },

        };
    }
}
    