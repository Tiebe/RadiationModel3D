using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium91m";
        public override double halfLife { get; } = 2982.6d;
        public override double atomicWeight { get; } = 90.90789d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium91() }, { 0.95d, new GammaParticle(555570.0, 0.00223) }, { 0.0015254464735d, new GammaParticle(2027.0, 0.61166) }, { 0.008969988015411585d, new GammaParticle(14883.0, 0.08331) }, { 0.01720036052811426d, new GammaParticle(14958.0, 0.08289) }, { 0.004318797413421928d, new GammaParticle(16803.0, 0.07379) }, { 0.004914791456474154d, new GammaParticle(16880.0, 0.07345) }, { 0.000595994043052226d, new GammaParticle(17011.0, 0.07288) } } },
            { 0.015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium91() }, { 1.0d, new BetaParticle(-1, 1049945.0) } } },

        };
    }
}
    