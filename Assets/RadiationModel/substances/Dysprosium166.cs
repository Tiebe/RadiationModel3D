using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium166";
        public override double halfLife { get; } = 293760.0d;
        public override double atomicWeight { get; } = 165.93281d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium166() }, { 1.0d, new BetaParticle(-1, 242900.00001) }, { 0.011316d, new GammaParticle(28227.0, 0.04392) }, { 0.008142d, new GammaParticle(54239.0, 0.02286) }, { 0.138d, new GammaParticle(82470.0, 0.01503) }, { 0.000138d, new GammaParticle(290660.0, 0.00427) }, { 0.000552d, new GammaParticle(343510.0, 0.00361) }, { 0.0052439999999999995d, new GammaParticle(371750.0, 0.00334) }, { 0.005796d, new GammaParticle(425990.0, 0.00291) }, { 0.17875975299441d, new GammaParticle(7656.0, 0.16194) }, { 0.14136894755203241d, new GammaParticle(46700.0, 0.02655) }, { 0.25177016482997755d, new GammaParticle(47547.0, 0.02608) }, { 0.08134235444284922d, new GammaParticle(53982.0, 0.02297) }, { 0.10249136659799002d, new GammaParticle(54577.0, 0.02272) }, { 0.021149012155140798d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    