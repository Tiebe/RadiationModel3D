using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine83 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine83";
        public override double halfLife { get; } = 8546.4d;
        public override double atomicWeight { get; } = 82.91517d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton83() }, { 1.0d, new BetaParticle(-1, 488321.5) }, { 6.5e-06d, new GammaParticle(32151.6, 0.03856) }, { 2.379e-05d, new GammaParticle(118960.0, 0.01042) }, { 6.499999999999999e-07d, new GammaParticle(128550.0, 0.00964) }, { 0.0006227d, new GammaParticle(520397.0, 0.00238) }, { 0.013000000000000001d, new GammaParticle(529589.0, 0.00234) }, { 0.000221d, new GammaParticle(552546.0, 0.00224) }, { 0.0001339d, new GammaParticle(648587.0, 0.00191) }, { 4.069e-05d, new GammaParticle(680727.0, 0.00182) }, { 1.3e-07d, new GammaParticle(790100.0, 0.00157) }, { 0.00025d, new GammaParticle(1648.0, 0.75233) }, { 0.0006d, new GammaParticle(12596.0, 0.09843) }, { 0.0012d, new GammaParticle(12649.0, 0.09802) }, { 0.00028000000000000003d, new GammaParticle(14169.0, 0.0875) }, { 0.00031d, new GammaParticle(14209.0, 0.08726) }, { 2.8e-05d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    