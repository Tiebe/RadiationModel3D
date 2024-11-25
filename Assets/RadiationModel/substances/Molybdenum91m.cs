using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum91m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum91m";
        public override double halfLife { get; } = 64.6d;
        public override double atomicWeight { get; } = 90.91245d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum91() }, { 0.48200000000000004d, new GammaParticle(652900.0, 0.0019) }, { 0.00068738853378d, new GammaParticle(2440.0, 0.50813) }, { 0.0034072172446853806d, new GammaParticle(17374.0, 0.07136) }, { 0.006493648265076007d, new GammaParticle(17479.0, 0.07093) }, { 0.0017039097835689877d, new GammaParticle(19681.0, 0.063) }, { 0.0019663118902386117d, new GammaParticle(19794.0, 0.06264) }, { 0.0002624021066696241d, new GammaParticle(19963.0, 0.06211) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium91() }, { 1.0d, new BetaParticle(1, 3169795.0) }, { 0.0017000000000000001d, new GammaParticle(425900.0, 0.00291) }, { 0.0017000000000000001d, new GammaParticle(732640.0, 0.00169) }, { 0.0053d, new GammaParticle(1032740.0, 0.0012) }, { 0.005d, new GammaParticle(1082180.0, 0.00115) }, { 0.0028000000000000004d, new GammaParticle(1158540.0, 0.00107) }, { 0.18600000000000003d, new GammaParticle(1208110.0, 0.00103) }, { 0.242d, new GammaParticle(1508000.0, 0.00082) }, { 0.0072d, new GammaParticle(2240700.0, 0.00055) }, { 0.8815999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.0021987948619254997d, new GammaParticle(2299.0, 0.5393) }, { 0.011745622460052861d, new GammaParticle(16521.0, 0.07505) }, { 0.0224324340337144d, new GammaParticle(16615.0, 0.07462) }, { 0.005804325594115431d, new GammaParticle(18694.0, 0.06632) }, { 0.006674974433232745d, new GammaParticle(18795.0, 0.06597) }, { 0.0008706488391173146d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    