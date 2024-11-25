using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium112";
        public override double halfLife { get; } = 892.8d;
        public override double atomicWeight { get; } = 111.90554d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver112() }, { 1.0d, new BetaParticle(1, -703150.0) }, { 0.00033d, new GammaParticle(120680.0, 0.01027) }, { 2.1e-05d, new GammaParticle(244860.0, 0.00506) }, { 0.00035000000000000005d, new GammaParticle(402500.0, 0.00308) }, { 0.00010999999999999999d, new GammaParticle(558700.0, 0.00222) }, { 0.016d, new GammaParticle(606821.0, 0.00204) }, { 0.07d, new GammaParticle(617517.0, 0.00201) }, { 1e-05d, new GammaParticle(687410.0, 0.0018) }, { 0.0001d, new GammaParticle(688230.0, 0.0018) }, { 0.00016d, new GammaParticle(694872.0, 0.00178) }, { 2.3e-05d, new GammaParticle(808820.0, 0.00153) }, { 0.0007000000000000001d, new GammaParticle(815790.0, 0.00152) }, { 0.00012d, new GammaParticle(831790.0, 0.00149) }, { 5e-06d, new GammaParticle(842800.0, 0.00147) }, { 0.0021d, new GammaParticle(851285.0, 0.00146) }, { 8e-05d, new GammaParticle(897070.0, 0.00138) }, { 0.0031d, new GammaParticle(1253560.0, 0.00099) }, { 7.000000000000001e-05d, new GammaParticle(1312360.0, 0.00094) }, { 0.0011d, new GammaParticle(1468840.0, 0.00084) }, { 0.00064d, new GammaParticle(1504040.0, 0.00082) }, { 0.00017999999999999998d, new GammaParticle(1538680.0, 0.00081) }, { 0.00025d, new GammaParticle(1683220.0, 0.00074) }, { 1.8e-05d, new GammaParticle(2121490.0, 0.00058) }, { 1.6e-05d, new GammaParticle(2156200.0, 0.00058) }, { 0.480058d, new GammaParticle(511000.0, 0.00243) }, { 0.022799999999999997d, new GammaParticle(3388.0, 0.36595) }, { 0.08d, new GammaParticle(22983.0, 0.05395) }, { 0.151d, new GammaParticle(23173.0, 0.0535) }, { 0.042d, new GammaParticle(26184.0, 0.04735) }, { 0.05d, new GammaParticle(26381.0, 0.047) }, { 0.0077d, new GammaParticle(26641.0, 0.04654) } } },
            { 0.38d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin112() }, { 1.0d, new BetaParticle(-1, 332525.0) } } },

        };
    }
}
    