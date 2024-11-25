using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium166m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 165.94335d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium166() }, { 0.0392d, new GammaParticle(37000.0, 0.03351) }, { 0.08960000000000001d, new GammaParticle(70000.0, 0.01771) }, { 0.0392d, new GammaParticle(78000.0, 0.0159) }, { 0.1344d, new GammaParticle(99800.0, 0.01242) }, { 0.0672d, new GammaParticle(105000.0, 0.01181) }, { 0.027999999999999997d, new GammaParticle(137000.0, 0.00905) }, { 0.3696d, new GammaParticle(146300.0, 0.00847) }, { 0.4592d, new GammaParticle(160800.0, 0.00771) }, { 0.0616d, new GammaParticle(178300.0, 0.00695) }, { 0.56d, new GammaParticle(183100.0, 0.00677) }, { 0.1176d, new GammaParticle(248700.0, 0.00499) }, { 0.084d, new GammaParticle(938600.0, 0.00132) }, { 0.0784d, new GammaParticle(1009100.0, 0.00123) }, { 0.168d, new GammaParticle(1088100.0, 0.00114) }, { 0.044800000000000006d, new GammaParticle(1119300.0, 0.00111) }, { 0.19039999999999999d, new GammaParticle(1169900.0, 0.00106) }, { 0.2016d, new GammaParticle(1187500.0, 0.00104) }, { 0.055999999999999994d, new GammaParticle(1224300.0, 0.00101) }, { 0.1008d, new GammaParticle(1249200.0, 0.00099) }, { 0.0168d, new GammaParticle(1280100.0, 0.00097) }, { 0.284381889792d, new GammaParticle(6858.0, 0.18079) }, { 0.24316981799261697d, new GammaParticle(42308.0, 0.02931) }, { 0.43743446301963834d, new GammaParticle(42996.0, 0.02884) }, { 0.1382763725318644d, new GammaParticle(48802.0, 0.02541) }, { 0.17464305850774473d, new GammaParticle(49326.0, 0.02514) }, { 0.03636668597588034d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    