using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium164";
        public override double halfLife { get; } = 1728.0d;
        public override double atomicWeight { get; } = 163.93024d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium164() }, { 1.0d, new BetaParticle(1, -1437750.0) }, { 0.018799999999999997d, new GammaParticle(73392.0, 0.01689) }, { 5.7e-06d, new GammaParticle(689300.0, 0.0018) }, { 4.7e-06d, new GammaParticle(762400.0, 0.00163) }, { 0.125148360179472d, new GammaParticle(7384.0, 0.16791) }, { 0.14615950242497278d, new GammaParticle(45207.0, 0.02743) }, { 0.2611856726679285d, new GammaParticle(45998.0, 0.02695) }, { 0.0838613796976973d, new GammaParticle(52220.0, 0.02374) }, { 0.1056653384190986d, new GammaParticle(52791.0, 0.02349) }, { 0.0218039587214013d, new GammaParticle(53478.0, 0.02318) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium164() }, { 1.0d, new BetaParticle(-1, 481050.0) }, { 0.023d, new GammaParticle(91390.0, 0.01357) }, { 0.016250983776d, new GammaParticle(7933.0, 0.15629) }, { 0.008130100211041415d, new GammaParticle(48222.0, 0.02571) }, { 0.01443042280980017d, new GammaParticle(49128.0, 0.02524) }, { 0.00468936585647493d, new GammaParticle(55779.0, 0.02223) }, { 0.005908600979158411d, new GammaParticle(56399.0, 0.02198) }, { 0.0012192351226834818d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    