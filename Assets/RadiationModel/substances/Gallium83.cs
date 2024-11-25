using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium83";
        public override double halfLife { get; } = 0.3081d;
        public override double atomicWeight { get; } = 82.94712d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium83() }, { 1.0d, new BetaParticle(-1, 5859650.00001) }, { 0.00426d, new GammaParticle(247050.0, 0.00502) }, { 0.006532d, new GammaParticle(1045500.0, 0.00119) }, { 0.019028d, new GammaParticle(1237960.0, 0.001) } } },
            { 0.628d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium83() }, { 1.0d, new BetaParticle(-1, 5859650.00001) }, { 0.00426d, new GammaParticle(247050.0, 0.00502) }, { 0.006532d, new GammaParticle(1045500.0, 0.00119) }, { 0.019028d, new GammaParticle(1237960.0, 0.001) } } },

        };
    }
}
    