using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony125 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony125";
        public override double halfLife { get; } = 87051673.71647d;
        public override double atomicWeight { get; } = 124.90525d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium125() }, { 1.0d, new BetaParticle(-1, 383350.0) }, { 0.00020424d, new GammaParticle(19800.0, 0.06262) }, { 0.043748800000000004d, new GammaParticle(35489.0, 0.03494) }, { 0.00012432d, new GammaParticle(58430.0, 0.02122) }, { 2.072e-05d, new GammaParticle(61850.0, 0.02005) }, { 5.032e-05d, new GammaParticle(81020.0, 0.0153) }, { 1.036e-05d, new GammaParticle(110895.0, 0.01118) }, { 0.00262552d, new GammaParticle(116955.0, 0.0106) }, { 8.584000000000001e-06d, new GammaParticle(132810.0, 0.00934) }, { 0.00191216d, new GammaParticle(172719.0, 0.00718) }, { 0.0684056d, new GammaParticle(176314.0, 0.00703) }, { 0.00033744000000000005d, new GammaParticle(178842.0, 0.00693) }, { 0.000127872d, new GammaParticle(198654.0, 0.00624) }, { 0.0031672000000000002d, new GammaParticle(204138.0, 0.00607) }, { 0.00247752d, new GammaParticle(208077.0, 0.00596) }, { 0.00044992d, new GammaParticle(209320.0, 0.00592) }, { 0.00131128d, new GammaParticle(227891.0, 0.00544) }, { 4.0255999999999995e-05d, new GammaParticle(314950.0, 0.00394) }, { 0.00415584d, new GammaParticle(321040.0, 0.00386) }, { 2.516e-05d, new GammaParticle(331820.0, 0.00374) }, { 7.992000000000001e-05d, new GammaParticle(366560.0, 0.00338) }, { 0.01516704d, new GammaParticle(380452.0, 0.00326) }, { 6.216e-05d, new GammaParticle(401950.0, 0.00308) }, { 0.00184408d, new GammaParticle(408065.0, 0.00304) }, { 0.29600000000000004d, new GammaParticle(427874.0, 0.0029) }, { 0.0030636d, new GammaParticle(443555.0, 0.0028) }, { 0.104932d, new GammaParticle(463365.0, 0.00268) }, { 1.3616e-05d, new GammaParticle(489730.0, 0.00253) }, { 4.736e-05d, new GammaParticle(491290.0, 0.00252) }, { 3.1968e-05d, new GammaParticle(497370.0, 0.00249) }, { 3.848e-05d, new GammaParticle(503100.0, 0.00246) }, { 1.3912e-05d, new GammaParticle(538620.0, 0.0023) }, { 0.1764752d, new GammaParticle(600597.0, 0.00206) }, { 0.0498168d, new GammaParticle(606713.0, 0.00204) }, { 5.3280000000000005e-05d, new GammaParticle(617400.0, 0.00201) }, { 0.112184d, new GammaParticle(635950.0, 0.00195) }, { 2.6640000000000002e-05d, new GammaParticle(652800.0, 0.0019) }, { 0.01790504d, new GammaParticle(671441.0, 0.00185) }, { 9.176e-07d, new GammaParticle(693300.0, 0.00179) }, { 0.0481807591708633d, new GammaParticle(4135.0, 0.29984) }, { 0.13177578902335477d, new GammaParticle(27202.0, 0.04558) }, { 0.24539253076974815d, new GammaParticle(27473.0, 0.04513) }, { 0.07022706759664513d, new GammaParticle(31093.0, 0.03988) }, { 0.08546634126511712d, new GammaParticle(31359.0, 0.03954) }, { 0.01523927366847199d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    