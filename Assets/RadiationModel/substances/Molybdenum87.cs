using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum87 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum87";
        public override double halfLife { get; } = 14.1d;
        public override double atomicWeight { get; } = 86.9282d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium87() }, { 1.0d, new BetaParticle(1, 6231100.0) }, { 0.00385d, new GammaParticle(67000.0, 0.01851) }, { 0.033d, new GammaParticle(133900.0, 0.00926) }, { 0.55d, new GammaParticle(263000.0, 0.00471) }, { 0.022000000000000002d, new GammaParticle(334000.0, 0.00371) }, { 0.20350000000000001d, new GammaParticle(396800.0, 0.00312) }, { 1.96d, new GammaParticle(511000.0, 0.00243) }, { 0.00081443188465d, new GammaParticle(2299.0, 0.5393) }, { 0.004372173790968331d, new GammaParticle(16521.0, 0.07505) }, { 0.008350217324232872d, new GammaParticle(16615.0, 0.07462) }, { 0.0021605938998250393d, new GammaParticle(18694.0, 0.06632) }, { 0.002484682984798795d, new GammaParticle(18795.0, 0.06597) }, { 0.0003240890849737559d, new GammaParticle(18951.0, 0.06542) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium86() }, { 1.0d, new BetaParticle(1, 471289151.73601) }, { 1.0d, new ProtonParticle() }, { 0.15d, new GammaParticle(752000.0, 0.00165) }, { 0.038d, new GammaParticle(915000.0, 0.00136) }, { 0.015d, new GammaParticle(1004000.0, 0.00123) } } },

        };
    }
}
    