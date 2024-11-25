using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium28 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium28";
        public override double halfLife { get; } = 75294.0d;
        public override double atomicWeight { get; } = 27.98388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum28() }, { 1.0d, new BetaParticle(-1, 915385.0) }, { 0.89d, new GammaParticle(30638.3, 0.04047) }, { 0.359d, new GammaParticle(400600.0, 0.00309) }, { 0.0008500000000000001d, new GammaParticle(648100.0, 0.00191) }, { 0.363d, new GammaParticle(941700.0, 0.00132) }, { 0.002d, new GammaParticle(972240.0, 0.00128) }, { 0.54d, new GammaParticle(1342200.0, 0.00092) }, { 0.047d, new GammaParticle(1372800.0, 0.0009) }, { 0.047d, new GammaParticle(1589400.0, 0.00078) }, { 0.003d, new GammaParticle(1620000.0, 0.00077) }, { 4.4654148e-05d, new GammaParticle(91.0, 13.62464) }, { 0.0013464208320539087d, new GammaParticle(1487.0, 0.83379) }, { 0.0006776536047727323d, new GammaParticle(1487.0, 0.83379) }, { 4.2505563173359456e-05d, new GammaParticle(1558.0, 0.79579) }, { 4.2505563173359456e-05d, new GammaParticle(1558.0, 0.79579) } } },

        };
    }
}
    