using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium151m";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 150.92322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.934d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium151() }, { 0.031d, new GammaParticle(22920.0, 0.05409) }, { 1.07e-05d, new GammaParticle(27100.0, 0.04575) }, { 0.22d, new GammaParticle(49460.0, 0.02507) }, { 0.0011d, new GammaParticle(72500.0, 0.0171) }, { 0.345602178222d, new GammaParticle(7118.0, 0.17418) }, { 0.0006761109009956243d, new GammaParticle(43743.0, 0.02834) }, { 0.0012123200663360664d, new GammaParticle(44481.0, 0.02787) }, { 0.00038713584802883984d, new GammaParticle(50494.0, 0.02455) }, { 0.00048740403266830934d, new GammaParticle(51040.0, 0.02429) }, { 0.00010026818463946952d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.066d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium151() }, { 1.0d, new BetaParticle(1, 1564550.0) }, { 0.063d, new GammaParticle(379700.0, 0.00327) }, { 0.0051d, new GammaParticle(504500.0, 0.00246) }, { 0.015d, new GammaParticle(522400.0, 0.00237) }, { 0.033d, new GammaParticle(830500.0, 0.00149) }, { 0.00332d, new GammaParticle(511000.0, 0.00243) }, { 0.010601786799999999d, new GammaParticle(6858.0, 0.18079) }, { 0.015930431449563756d, new GammaParticle(42308.0, 0.02931) }, { 0.028657009263471412d, new GammaParticle(42996.0, 0.02884) }, { 0.009058699356266686d, new GammaParticle(48802.0, 0.02541) }, { 0.011441137286964824d, new GammaParticle(49326.0, 0.02514) }, { 0.002382437930698138d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    