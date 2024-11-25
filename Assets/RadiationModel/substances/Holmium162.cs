using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium162";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 161.9291d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium162() }, { 1.0d, new BetaParticle(1, -80750.0) }, { 0.08d, new GammaParticle(80700.0, 0.01536) }, { 0.0042d, new GammaParticle(185000.0, 0.0067) }, { 6.9e-05d, new GammaParticle(392485.0, 0.00316) }, { 0.0031d, new GammaParticle(512000.0, 0.00242) }, { 0.00023d, new GammaParticle(540000.0, 0.0023) }, { 0.00073d, new GammaParticle(807650.0, 0.00154) }, { 0.00061d, new GammaParticle(888000.0, 0.0014) }, { 0.00037999999999999997d, new GammaParticle(1134000.0, 0.00109) }, { 0.00481d, new GammaParticle(1187850.0, 0.00104) }, { 0.00073d, new GammaParticle(1195100.0, 0.00104) }, { 0.00015d, new GammaParticle(1276000.0, 0.00097) }, { 0.0382d, new GammaParticle(1319750.0, 0.00094) }, { 0.0079d, new GammaParticle(1372930.0, 0.0009) }, { 0.00027d, new GammaParticle(1453770.0, 0.00085) }, { 4.6e-05d, new GammaParticle(1517200.0, 0.00082) }, { 8e-05d, new GammaParticle(1669000.0, 0.00074) }, { 0.00017999999999999998d, new GammaParticle(1702200.0, 0.00073) }, { 5.7e-05d, new GammaParticle(1740000.0, 0.00071) }, { 0.000157d, new GammaParticle(1783000.0, 0.0007) }, { 0.00015d, new GammaParticle(1806000.0, 0.00069) }, { 0.076d, new GammaParticle(511000.0, 0.00243) }, { 0.23022403913980266d, new GammaParticle(7384.0, 0.16791) }, { 0.24976208102023364d, new GammaParticle(45207.0, 0.02743) }, { 0.44632251790606436d, new GammaParticle(45998.0, 0.02695) }, { 0.14330503568371566d, new GammaParticle(52220.0, 0.02374) }, { 0.18056434496148174d, new GammaParticle(52791.0, 0.02349) }, { 0.03725930927776608d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    