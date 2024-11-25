using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium153m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 152.92186d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium153() }, { 0.094d, new GammaParticle(41560.0, 0.02983) }, { 0.047d, new GammaParticle(51780.0, 0.02394) }, { 0.01034d, new GammaParticle(93340.0, 0.01328) }, { 0.2194931772d, new GammaParticle(6858.0, 0.18079) }, { 0.14079614041353905d, new GammaParticle(42308.0, 0.02931) }, { 0.2532760216109715d, new GammaParticle(42996.0, 0.02884) }, { 0.08006248359104466d, new GammaParticle(48802.0, 0.02541) }, { 0.10111891677548941d, new GammaParticle(49326.0, 0.02514) }, { 0.021056433184444744d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    