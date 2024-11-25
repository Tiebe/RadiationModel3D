using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron68 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron68";
        public override double halfLife { get; } = 0.188d;
        public override double atomicWeight { get; } = 67.95287d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt68() }, { 1.0d, new BetaParticle(-1, 3871500.0) }, { 0.24d, new GammaParticle(44800.0, 0.02768) }, { 0.1d, new GammaParticle(161500.0, 0.00768) }, { 0.069d, new GammaParticle(183800.0, 0.00675) }, { 0.015d, new GammaParticle(210900.0, 0.00588) }, { 0.018000000000000002d, new GammaParticle(326700.0, 0.0038) }, { 0.009000000000000001d, new GammaParticle(345700.0, 0.00359) }, { 0.04d, new GammaParticle(358300.0, 0.00346) }, { 0.027000000000000003d, new GammaParticle(519900.0, 0.00238) }, { 0.019d, new GammaParticle(630100.0, 0.00197) }, { 0.018000000000000002d, new GammaParticle(649400.0, 0.00191) }, { 0.025d, new GammaParticle(694100.0, 0.00179) }, { 0.018000000000000002d, new GammaParticle(883300.0, 0.0014) }, { 0.11d, new GammaParticle(973000.0, 0.00127) }, { 0.011000000000000001d, new GammaParticle(979600.0, 0.00127) }, { 0.067d, new GammaParticle(1021200.0, 0.00121) }, { 0.005d, new GammaParticle(1039300.0, 0.00119) }, { 0.004d, new GammaParticle(1206000.0, 0.00103) }, { 0.018000000000000002d, new GammaParticle(1251600.0, 0.00099) }, { 0.012d, new GammaParticle(1367800.0, 0.00091) }, { 0.015d, new GammaParticle(1423500.0, 0.00087) }, { 0.013999999999999999d, new GammaParticle(1460600.0, 0.00085) }, { 0.013999999999999999d, new GammaParticle(1545900.0, 0.0008) }, { 0.011000000000000001d, new GammaParticle(2615300.0, 0.00047) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt68() }, { 1.0d, new BetaParticle(-1, 3871500.0) }, { 0.24d, new GammaParticle(44800.0, 0.02768) }, { 0.1d, new GammaParticle(161500.0, 0.00768) }, { 0.069d, new GammaParticle(183800.0, 0.00675) }, { 0.015d, new GammaParticle(210900.0, 0.00588) }, { 0.018000000000000002d, new GammaParticle(326700.0, 0.0038) }, { 0.009000000000000001d, new GammaParticle(345700.0, 0.00359) }, { 0.04d, new GammaParticle(358300.0, 0.00346) }, { 0.027000000000000003d, new GammaParticle(519900.0, 0.00238) }, { 0.019d, new GammaParticle(630100.0, 0.00197) }, { 0.018000000000000002d, new GammaParticle(649400.0, 0.00191) }, { 0.025d, new GammaParticle(694100.0, 0.00179) }, { 0.018000000000000002d, new GammaParticle(883300.0, 0.0014) }, { 0.11d, new GammaParticle(973000.0, 0.00127) }, { 0.011000000000000001d, new GammaParticle(979600.0, 0.00127) }, { 0.067d, new GammaParticle(1021200.0, 0.00121) }, { 0.005d, new GammaParticle(1039300.0, 0.00119) }, { 0.004d, new GammaParticle(1206000.0, 0.00103) }, { 0.018000000000000002d, new GammaParticle(1251600.0, 0.00099) }, { 0.012d, new GammaParticle(1367800.0, 0.00091) }, { 0.015d, new GammaParticle(1423500.0, 0.00087) }, { 0.013999999999999999d, new GammaParticle(1460600.0, 0.00085) }, { 0.013999999999999999d, new GammaParticle(1545900.0, 0.0008) }, { 0.011000000000000001d, new GammaParticle(2615300.0, 0.00047) } } },

        };
    }
}
    