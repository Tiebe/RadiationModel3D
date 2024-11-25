using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium88n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium88n";
        public override double halfLife { get; } = 0.01398d;
        public override double atomicWeight { get; } = 87.91023d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium88() }, { 0.9809d, new GammaParticle(231929.0, 0.00535) }, { 0.9822d, new GammaParticle(442620.0, 0.0028) }, { 0.0010988267556582998d, new GammaParticle(2027.0, 0.61166) }, { 0.006527871743311906d, new GammaParticle(14883.0, 0.08331) }, { 0.01251749135822034d, new GammaParticle(14958.0, 0.08289) }, { 0.0031429869863512793d, new GammaParticle(16803.0, 0.07379) }, { 0.003576719190467756d, new GammaParticle(16880.0, 0.07345) }, { 0.0004337322041164766d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    