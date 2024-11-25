using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon10 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon10";
        public override double halfLife { get; } = 19.29d;
        public override double atomicWeight { get; } = 10.01685d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium10() }, { 1.0d, new BetaParticle(1, 1545590.0) }, { 1.0d, new GammaParticle(718353.0, 0.00173) }, { 0.014615d, new GammaParticle(1021646.0, 0.00121) }, { 1.999202d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    