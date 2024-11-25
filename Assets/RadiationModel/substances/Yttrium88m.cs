using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium88m";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 87.90992d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium88() }, { 0.9721d, new GammaParticle(392870.0, 0.00316) }, { 0.000818815879371d, new GammaParticle(2027.0, 0.61166) }, { 0.00480021734100611d, new GammaParticle(14883.0, 0.08331) }, { 0.009204635361469052d, new GammaParticle(14958.0, 0.08289) }, { 0.002311169892376833d, new GammaParticle(16803.0, 0.07379) }, { 0.002630111337524836d, new GammaParticle(16880.0, 0.07345) }, { 0.0003189414451480029d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    