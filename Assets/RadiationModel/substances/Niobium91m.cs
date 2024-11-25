using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium91m";
        public override double halfLife { get; } = 5258304.0d;
        public override double atomicWeight { get; } = 90.9071d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.966d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium91() }, { 0.0057399999999999994d, new GammaParticle(104620.0, 0.01185) }, { 0.03293706997d, new GammaParticle(2299.0, 0.5393) }, { 0.14500715955467217d, new GammaParticle(16521.0, 0.07505) }, { 0.2769426271097635d, new GammaParticle(16615.0, 0.07462) }, { 0.07165808116136026d, new GammaParticle(18694.0, 0.06632) }, { 0.08240679333556429d, new GammaParticle(18795.0, 0.06597) }, { 0.010748712174204039d, new GammaParticle(18951.0, 0.06542) } } },
            { 0.034d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium91() }, { 1.0d, new BetaParticle(1, -91050.0) }, { 0.0202d, new GammaParticle(1204670.0, 0.00103) }, { 2.6e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.0011130464179728d, new GammaParticle(2161.0, 0.57374) }, { 0.006191912924844125d, new GammaParticle(15691.0, 0.07902) }, { 0.011850551052333253d, new GammaParticle(15775.0, 0.0786) }, { 0.003019672417820787d, new GammaParticle(17736.0, 0.06991) }, { 0.003460544590822621d, new GammaParticle(17824.0, 0.06956) }, { 0.0004408721730018349d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    