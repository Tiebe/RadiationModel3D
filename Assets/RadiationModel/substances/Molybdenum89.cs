using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum89 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum89";
        public override double halfLife { get; } = 126.6d;
        public override double atomicWeight { get; } = 88.91947d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium89() }, { 1.0d, new BetaParticle(1, 4931500.0) }, { 0.0020369999999999997d, new GammaParticle(496400.0, 0.0025) }, { 0.05838d, new GammaParticle(658600.0, 0.00188) }, { 0.00903d, new GammaParticle(803000.0, 0.00154) }, { 0.0378d, new GammaParticle(844000.0, 0.00147) }, { 0.00966d, new GammaParticle(1035400.0, 0.0012) }, { 0.0147d, new GammaParticle(1131000.0, 0.0011) }, { 0.01848d, new GammaParticle(1155300.0, 0.00107) }, { 0.028980000000000002d, new GammaParticle(1272000.0, 0.00097) }, { 0.00987d, new GammaParticle(1640200.0, 0.00076) }, { 0.011970000000000001d, new GammaParticle(2221000.0, 0.00056) }, { 0.00924d, new GammaParticle(2420000.0, 0.00051) }, { 1.9853999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.00115d, new GammaParticle(2299.0, 0.5393) }, { 0.0060999999999999995d, new GammaParticle(16521.0, 0.07505) }, { 0.011699999999999999d, new GammaParticle(16615.0, 0.07462) }, { 0.0030299999999999997d, new GammaParticle(18694.0, 0.06632) }, { 0.0034999999999999996d, new GammaParticle(18795.0, 0.06597) }, { 0.00045d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    