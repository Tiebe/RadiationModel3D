using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium199";
        public override double halfLife { get; } = 26712.0d;
        public override double atomicWeight { get; } = 198.96988d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold199() }, { 1.0d, new BetaParticle(1, 517400.00001) }, { 0.0001116d, new GammaParticle(36830.0, 0.03366) }, { 0.005084d, new GammaParticle(49817.0, 0.02489) }, { 0.0002356d, new GammaParticle(51930.0, 0.02388) }, { 0.0496d, new GammaParticle(158359.0, 0.00783) }, { 0.0026040000000000004d, new GammaParticle(195300.0, 0.00635) }, { 9.92e-05d, new GammaParticle(205600.0, 0.00603) }, { 0.12276d, new GammaParticle(208200.0, 0.00596) }, { 0.000372d, new GammaParticle(245100.0, 0.00506) }, { 0.09300000000000001d, new GammaParticle(247260.0, 0.00501) }, { 0.000124d, new GammaParticle(255500.0, 0.00485) }, { 0.0007192d, new GammaParticle(258140.0, 0.0048) }, { 0.022071999999999998d, new GammaParticle(284090.0, 0.00436) }, { 0.0005208d, new GammaParticle(294940.0, 0.0042) }, { 0.0034720000000000003d, new GammaParticle(297070.0, 0.00417) }, { 0.017608d, new GammaParticle(333930.0, 0.00371) }, { 0.0014136d, new GammaParticle(336500.0, 0.00368) }, { 0.0013268d, new GammaParticle(346890.0, 0.00357) }, { 0.017236d, new GammaParticle(403500.0, 0.00307) }, { 0.001984d, new GammaParticle(413850.0, 0.003) }, { 0.124d, new GammaParticle(455460.0, 0.00272) }, { 0.0003844d, new GammaParticle(470770.0, 0.00263) }, { 0.015251999999999998d, new GammaParticle(492300.0, 0.00252) }, { 0.0026040000000000004d, new GammaParticle(542210.0, 0.00229) }, { 0.000992d, new GammaParticle(592000.0, 0.00209) }, { 0.0004464d, new GammaParticle(728860.0, 0.0017) }, { 0.010416000000000002d, new GammaParticle(750400.0, 0.00165) }, { 0.000124d, new GammaParticle(765700.0, 0.00162) }, { 0.000496d, new GammaParticle(807300.0, 0.00154) }, { 0.004092d, new GammaParticle(817670.0, 0.00152) }, { 0.017608d, new GammaParticle(1012950.0, 0.00122) }, { 0.00248d, new GammaParticle(1062800.0, 0.00117) }, { 0.0002976d, new GammaParticle(1221160.0, 0.00102) }, { 0.00054d, new GammaParticle(511000.0, 0.00243) }, { 0.375d, new GammaParticle(11777.0, 0.10528) }, { 0.275d, new GammaParticle(68894.0, 0.018) }, { 0.466d, new GammaParticle(70820.0, 0.01751) }, { 0.158d, new GammaParticle(80316.0, 0.01544) }, { 0.204d, new GammaParticle(81285.0, 0.01525) }, { 0.046d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    