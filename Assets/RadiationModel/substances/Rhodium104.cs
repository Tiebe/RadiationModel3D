using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium104";
        public override double halfLife { get; } = 42.3d;
        public override double atomicWeight { get; } = 103.90665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9954999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium104() }, { 1.0d, new BetaParticle(-1, 1217900.0) }, { 6.2e-05d, new GammaParticle(451160.0, 0.00275) }, { 3.6e-05d, new GammaParticle(460500.0, 0.00269) }, { 3e-05d, new GammaParticle(479100.0, 0.00259) }, { 2.8e-05d, new GammaParticle(488500.0, 0.00254) }, { 2.2000000000000003e-05d, new GammaParticle(497800.0, 0.00249) }, { 0.02d, new GammaParticle(555810.0, 0.00223) }, { 0.00010999999999999999d, new GammaParticle(767100.0, 0.00162) }, { 6.2e-05d, new GammaParticle(777770.0, 0.00159) }, { 3.6e-05d, new GammaParticle(785880.0, 0.00158) }, { 0.00066d, new GammaParticle(1237050.0, 0.001) }, { 0.0001d, new GammaParticle(1238020.0, 0.001) }, { 2.8e-05d, new GammaParticle(1341670.0, 0.00092) }, { 4.4e-06d, new GammaParticle(1689100.0, 0.00073) }, { 1e-05d, new GammaParticle(1793830.0, 0.00069) }, { 4.517676e-06d, new GammaParticle(3053.0, 0.40611) }, { 1.7968108059359256e-05d, new GammaParticle(21020.0, 0.05898) }, { 3.394692624099614e-05d, new GammaParticle(21177.0, 0.05855) }, { 9.313645897132135e-06d, new GammaParticle(23904.0, 0.05187) }, { 1.0896965699644598e-05d, new GammaParticle(24070.0, 0.05151) }, { 1.583319802512463e-06d, new GammaParticle(24297.0, 0.05103) } } },
            { 0.0045000000000000005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium104() }, { 1.0d, new BetaParticle(1, -2230150.0) }, { 0.00016d, new GammaParticle(358120.0, 0.00346) }, { 1e-05d, new GammaParticle(629600.0, 0.00197) }, { 5.422e-07d, new GammaParticle(511000.0, 0.00243) }, { 0.0002043328589470965d, new GammaParticle(2737.0, 0.45299) }, { 0.0009179302262498387d, new GammaParticle(19150.0, 0.06474) }, { 0.0017418030858630715d, new GammaParticle(19279.0, 0.06431) }, { 0.0004680855958064459d, new GammaParticle(21736.0, 0.05704) }, { 0.0005439154623270901d, new GammaParticle(21875.0, 0.05668) }, { 7.582986652064423e-05d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    