using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur38 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur38";
        public override double halfLife { get; } = 10218.0d;
        public override double atomicWeight { get; } = 37.97116d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine38() }, { 1.0d, new BetaParticle(-1, 1468560.0) }, { 0.0009d, new GammaParticle(196190.0, 0.00632) }, { 0.00015d, new GammaParticle(755425.0, 0.00164) }, { 0.00015d, new GammaParticle(936900.0, 0.00132) }, { 0.0017299999999999998d, new GammaParticle(1692640.0, 0.00073) }, { 0.0254d, new GammaParticle(1745770.0, 0.00071) }, { 0.865d, new GammaParticle(1941945.0, 0.00064) }, { 0.0144d, new GammaParticle(2750980.0, 0.00045) } } },

        };
    }
}
    