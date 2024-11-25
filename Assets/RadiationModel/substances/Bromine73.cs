using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine73 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine73";
        public override double halfLife { get; } = 204.0d;
        public override double atomicWeight { get; } = 72.93167d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic73() }, { 1.0d, new BetaParticle(1, 3653500.0) }, { 0.37d, new GammaParticle(65000.0, 0.01907) }, { 0.07548d, new GammaParticle(125600.0, 0.00987) }, { 0.00481d, new GammaParticle(166200.0, 0.00746) }, { 0.00111d, new GammaParticle(192600.0, 0.00644) }, { 0.00333d, new GammaParticle(249400.0, 0.00497) }, { 0.02701d, new GammaParticle(275200.0, 0.00451) }, { 0.10433999999999999d, new GammaParticle(335900.0, 0.00369) }, { 0.00777d, new GammaParticle(363900.0, 0.00341) }, { 0.0222d, new GammaParticle(374700.0, 0.00331) }, { 0.00888d, new GammaParticle(390400.0, 0.00318) }, { 0.05957d, new GammaParticle(400900.0, 0.00309) }, { 0.010360000000000001d, new GammaParticle(489800.0, 0.00253) }, { 0.01887d, new GammaParticle(540000.0, 0.0023) }, { 0.01887d, new GammaParticle(540000.0, 0.0023) }, { 0.00666d, new GammaParticle(550600.0, 0.00225) }, { 0.00185d, new GammaParticle(595300.0, 0.00208) }, { 0.020720000000000002d, new GammaParticle(615300.0, 0.00202) }, { 0.010360000000000001d, new GammaParticle(639000.0, 0.00194) }, { 0.09139d, new GammaParticle(699800.0, 0.00177) }, { 0.0074d, new GammaParticle(764700.0, 0.00162) }, { 0.00888d, new GammaParticle(788800.0, 0.00157) }, { 0.05846d, new GammaParticle(849400.0, 0.00146) }, { 0.012580000000000001d, new GammaParticle(870700.0, 0.00142) }, { 0.05143d, new GammaParticle(914300.0, 0.00136) }, { 0.05846d, new GammaParticle(931400.0, 0.00133) }, { 0.0037d, new GammaParticle(984700.0, 0.00126) }, { 0.01887d, new GammaParticle(996200.0, 0.00124) }, { 0.01184d, new GammaParticle(1460200.0, 0.00085) }, { 0.00555d, new GammaParticle(1528800.0, 0.00081) }, { 1.8796000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.0033981606699810003d, new GammaParticle(1426.0, 0.86945) }, { 0.02600627879999379d, new GammaParticle(11183.0, 0.11087) }, { 0.0504193074835087d, new GammaParticle(11223.0, 0.11047) }, { 0.011765575013915458d, new GammaParticle(12546.0, 0.09882) }, { 0.012426800329697505d, new GammaParticle(12571.0, 0.09863) }, { 0.0006612253157820487d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    