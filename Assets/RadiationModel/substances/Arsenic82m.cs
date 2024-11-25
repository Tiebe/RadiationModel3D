using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic82m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic82m";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 81.92488d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium82() }, { 1.0d, new BetaParticle(-1, 3810450.0) }, { 0.6525d, new GammaParticle(343700.0, 0.00361) }, { 0.14400000000000002d, new GammaParticle(560500.0, 0.00221) }, { 0.75d, new GammaParticle(654400.0, 0.00189) }, { 0.1125d, new GammaParticle(814700.0, 0.00152) }, { 0.345d, new GammaParticle(818300.0, 0.00152) }, { 0.09d, new GammaParticle(1075600.0, 0.00115) }, { 0.195d, new GammaParticle(1079300.0, 0.00115) }, { 0.0345d, new GammaParticle(1157600.0, 0.00107) }, { 0.0735d, new GammaParticle(1539600.0, 0.00081) }, { 0.255d, new GammaParticle(1730000.0, 0.00072) }, { 0.465d, new GammaParticle(1894200.0, 0.00065) } } },

        };
    }
}
    