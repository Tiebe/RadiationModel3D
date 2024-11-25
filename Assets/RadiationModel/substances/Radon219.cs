using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon219 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon219";
        public override double halfLife { get; } = 3.96d;
        public override double atomicWeight { get; } = 219.00948d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium215() }, { 1.0d, new AlphaParticle(7968102.09) }, { 0.0012959999999999998d, new GammaParticle(130600.0, 0.00949) }, { 0.0003024d, new GammaParticle(221500.0, 0.0056) }, { 1.4040000000000001e-05d, new GammaParticle(224000.0, 0.00554) }, { 0.10800000000000001d, new GammaParticle(271230.0, 0.00457) }, { 0.0007344000000000001d, new GammaParticle(293560.0, 0.00422) }, { 8.64e-07d, new GammaParticle(321800.0, 0.00385) }, { 6.48e-05d, new GammaParticle(324900.0, 0.00382) }, { 9.72e-06d, new GammaParticle(330800.0, 0.00375) }, { 8.64e-05d, new GammaParticle(337700.0, 0.00367) }, { 0.00010800000000000001d, new GammaParticle(370900.0, 0.00334) }, { 2.4840000000000003e-06d, new GammaParticle(373500.0, 0.00332) }, { 3.24e-07d, new GammaParticle(380000.0, 0.00326) }, { 4.32e-06d, new GammaParticle(383100.0, 0.00324) }, { 0.06588d, new GammaParticle(401810.0, 0.00309) }, { 2.4840000000000003e-06d, new GammaParticle(405400.0, 0.00306) }, { 3.0239999999999998e-06d, new GammaParticle(436900.0, 0.00284) }, { 0.0003024d, new GammaParticle(438200.0, 0.00283) }, { 1.6200000000000002e-06d, new GammaParticle(461600.0, 0.00269) }, { 6.2640000000000005e-06d, new GammaParticle(489300.0, 0.00253) }, { 0.0004428d, new GammaParticle(517600.0, 0.0024) }, { 6.48e-05d, new GammaParticle(538200.0, 0.0023) }, { 5.4e-07d, new GammaParticle(556100.0, 0.00223) }, { 1.5120000000000001e-05d, new GammaParticle(564100.0, 0.0022) }, { 8.64e-07d, new GammaParticle(576600.0, 0.00215) }, { 4.32e-05d, new GammaParticle(608300.0, 0.00204) }, { 3.2400000000000003e-06d, new GammaParticle(619900.0, 0.002) }, { 2.16e-06d, new GammaParticle(671900.0, 0.00185) }, { 0.0001728d, new GammaParticle(676660.0, 0.00183) }, { 3.2400000000000003e-06d, new GammaParticle(708100.0, 0.00175) }, { 6.48e-07d, new GammaParticle(732800.0, 0.00169) }, { 3.2400000000000003e-06d, new GammaParticle(802500.0, 0.00154) }, { 1.62e-05d, new GammaParticle(835300.0, 0.00148) }, { 3.2400000000000003e-06d, new GammaParticle(877200.0, 0.00141) }, { 7.5600000000000005e-06d, new GammaParticle(891100.0, 0.00139) }, { 6.480000000000001e-06d, new GammaParticle(1055000.0, 0.00118) }, { 3.2400000000000003e-06d, new GammaParticle(1073700.0, 0.00115) }, { 0.01015808439460464d, new GammaParticle(13292.0, 0.09328) }, { 0.00547529805787232d, new GammaParticle(76862.0, 0.01613) }, { 0.009117898514358567d, new GammaParticle(79290.0, 0.01564) }, { 0.0031390399949421132d, new GammaParticle(89837.0, 0.0138) }, { 0.004115281433369111d, new GammaParticle(90941.0, 0.01363) }, { 0.0009762414384269972d, new GammaParticle(92315.0, 0.01343) } } },

        };
    }
}
    