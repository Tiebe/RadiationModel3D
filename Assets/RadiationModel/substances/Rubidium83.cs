using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium83";
        public override double halfLife { get; } = 7447680.0d;
        public override double atomicWeight { get; } = 82.91511d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton83() }, { 0.058557d, new GammaParticle(9405.7, 0.13182) }, { 0.0003576d, new GammaParticle(32151.6, 0.03856) }, { 0.00014304d, new GammaParticle(119320.0, 0.01039) }, { 1.341e-05d, new GammaParticle(128550.0, 0.00964) }, { 4.917e-06d, new GammaParticle(237190.0, 0.00523) }, { 0.447d, new GammaParticle(520399.1, 0.00238) }, { 0.293232d, new GammaParticle(529594.5, 0.00234) }, { 0.159579d, new GammaParticle(552551.2, 0.00224) }, { 8.493e-05d, new GammaParticle(562170.0, 0.00221) }, { 0.0008493000000000001d, new GammaParticle(648970.0, 0.00191) }, { 0.00031289999999999996d, new GammaParticle(681180.0, 0.00182) }, { 0.006570899999999999d, new GammaParticle(790150.0, 0.00157) }, { 0.0023691000000000003d, new GammaParticle(799370.0, 0.00155) }, { 0.055d, new GammaParticle(1648.0, 0.75233) }, { 0.19899999999999998d, new GammaParticle(12596.0, 0.09843) }, { 0.38299999999999995d, new GammaParticle(12649.0, 0.09802) }, { 0.092d, new GammaParticle(14169.0, 0.0875) }, { 0.10099999999999999d, new GammaParticle(14209.0, 0.08726) }, { 0.009300000000000001d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    