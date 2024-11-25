using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten185m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten185m";
        public override double halfLife { get; } = 100.2d;
        public override double atomicWeight { get; } = 184.95363d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten185() }, { 8.1e-10d, new GammaParticle(9530.0, 0.1301) }, { 0.0016887d, new GammaParticle(23540.0, 0.05267) }, { 7.794e-06d, new GammaParticle(23540.0, 0.05267) }, { 0.0007361d, new GammaParticle(42290.0, 0.02932) }, { 0.058022d, new GammaParticle(65860.0, 0.01883) }, { 0.00026846d, new GammaParticle(93300.0, 0.01329) }, { 0.00105219d, new GammaParticle(94590.0, 0.01311) }, { 0.0040701999999999995d, new GammaParticle(107850.0, 0.0115) }, { 0.0010175499999999999d, new GammaParticle(122050.0, 0.01016) }, { 0.0433d, new GammaParticle(131550.0, 0.00942) }, { 0.0058888d, new GammaParticle(164330.0, 0.00754) }, { 0.032648199999999995d, new GammaParticle(173680.0, 0.00714) }, { 0.008140399999999999d, new GammaParticle(187880.0, 0.0066) }, { 0.437199619896095d, new GammaParticle(9740.0, 0.12729) }, { 0.023701697937661054d, new GammaParticle(57983.0, 0.02138) }, { 0.04117022396675535d, new GammaParticle(59320.0, 0.0209) }, { 0.013646526742844264d, new GammaParticle(67335.0, 0.01841) }, { 0.017385675070383595d, new GammaParticle(68117.0, 0.0182) }, { 0.0037391483275393284d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    