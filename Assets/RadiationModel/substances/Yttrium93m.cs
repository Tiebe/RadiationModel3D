using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium93m";
        public override double halfLife { get; } = 0.82d;
        public override double atomicWeight { get; } = 92.91039d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium93() }, { 0.5123d, new GammaParticle(168499.0, 0.00736) }, { 0.998d, new GammaParticle(590238.0, 0.0021) }, { 0.0145921261251d, new GammaParticle(2027.0, 0.61166) }, { 0.08031749789526856d, new GammaParticle(14883.0, 0.08331) }, { 0.1540124600101027d, new GammaParticle(14958.0, 0.08289) }, { 0.038670620469796774d, new GammaParticle(16803.0, 0.07379) }, { 0.04400716609462872d, new GammaParticle(16880.0, 0.07345) }, { 0.005336545624831954d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    