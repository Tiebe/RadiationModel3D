using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium74";
        public override double halfLife { get; } = 0.06478d;
        public override double atomicWeight { get; } = 73.94427d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine74() }, { 1.0d, new BetaParticle(1, 6686000.0) }, { 3.8e-05d, new GammaParticle(53000.0, 0.02339) }, { 0.0025d, new GammaParticle(456000.0, 0.00272) }, { 8e-05d, new GammaParticle(695000.0, 0.00178) }, { 0.00018999999999999998d, new GammaParticle(748000.0, 0.00166) }, { 0.00052d, new GammaParticle(1198000.0, 0.00103) }, { 0.00026d, new GammaParticle(1204000.0, 0.00103) }, { 0.00029d, new GammaParticle(1233000.0, 0.00101) }, { 8.999999999999999e-05d, new GammaParticle(1286000.0, 0.00096) }, { 0.00012d, new GammaParticle(4244000.0, 0.00029) }, { 1.9931200000000002d, new GammaParticle(511000.0, 0.00243) }, { 5.095840904258e-05d, new GammaParticle(1648.0, 0.75233) }, { 0.00035084050597174627d, new GammaParticle(12596.0, 0.09843) }, { 0.0006765146663550834d, new GammaParticle(12649.0, 0.09802) }, { 0.00016211082252286547d, new GammaParticle(14169.0, 0.0875) }, { 0.0001784515934331703d, new GammaParticle(14209.0, 0.08726) }, { 1.634077091030484e-05d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    