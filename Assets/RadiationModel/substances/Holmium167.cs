using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium167";
        public override double halfLife { get; } = 10728.0d;
        public override double atomicWeight { get; } = 166.93314d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium167() }, { 1.0d, new BetaParticle(-1, 505130.0) }, { 0.00012d, new GammaParticle(16700.0, 0.07424) }, { 0.008d, new GammaParticle(57072.3, 0.02172) }, { 0.0045000000000000005d, new GammaParticle(73775.0, 0.01681) }, { 0.021d, new GammaParticle(79321.9, 0.01563) }, { 0.015d, new GammaParticle(83473.3, 0.01485) }, { 0.0009d, new GammaParticle(105750.0, 0.01172) }, { 0.00045d, new GammaParticle(131000.0, 0.00946) }, { 0.000674d, new GammaParticle(131700.0, 0.00941) }, { 0.0011d, new GammaParticle(148394.0, 0.00836) }, { 0.049d, new GammaParticle(207801.0, 0.00597) }, { 0.0017000000000000001d, new GammaParticle(208700.0, 0.00594) }, { 0.051d, new GammaParticle(237873.0, 0.00521) }, { 0.0021d, new GammaParticle(254700.0, 0.00487) }, { 0.000337d, new GammaParticle(303000.0, 0.00409) }, { 0.0073d, new GammaParticle(315000.0, 0.00394) }, { 0.24d, new GammaParticle(321336.0, 0.00386) }, { 0.0017000000000000001d, new GammaParticle(332000.0, 0.00373) }, { 0.56d, new GammaParticle(346547.0, 0.00358) }, { 0.008d, new GammaParticle(351310.0, 0.00353) }, { 0.034d, new GammaParticle(386200.0, 0.00321) }, { 0.009000000000000001d, new GammaParticle(398600.0, 0.00311) }, { 0.033d, new GammaParticle(403000.0, 0.00308) }, { 0.0012d, new GammaParticle(430000.0, 0.00288) }, { 0.021d, new GammaParticle(460000.0, 0.0027) }, { 0.0045000000000000005d, new GammaParticle(463000.0, 0.00268) }, { 0.0015d, new GammaParticle(480000.0, 0.00258) }, { 0.00017d, new GammaParticle(531500.0, 0.00233) }, { 0.0023d, new GammaParticle(668000.0, 0.00186) }, { 0.0017000000000000001d, new GammaParticle(745000.0, 0.00166) }, { 0.066d, new GammaParticle(7933.0, 0.15629) }, { 0.051d, new GammaParticle(48222.0, 0.02571) }, { 0.091d, new GammaParticle(49128.0, 0.02524) }, { 0.028999999999999998d, new GammaParticle(55779.0, 0.02223) }, { 0.037000000000000005d, new GammaParticle(56399.0, 0.02198) }, { 0.0076d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    