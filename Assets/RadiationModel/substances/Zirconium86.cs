using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium86";
        public override double halfLife { get; } = 59400.0d;
        public override double atomicWeight { get; } = 85.9163d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium86() }, { 1.0d, new BetaParticle(1, 3277050.0) }, { 0.21564d, new GammaParticle(29100.0, 0.04261) }, { 0.00046003200000000003d, new GammaParticle(94200.0, 0.01316) }, { 0.000699632d, new GammaParticle(127700.0, 0.00971) }, { 0.00469616d, new GammaParticle(135600.0, 0.00914) }, { 0.0009584d, new GammaParticle(160700.0, 0.00772) }, { 0.000699632d, new GammaParticle(173700.0, 0.00714) }, { 0.000824224d, new GammaParticle(207900.0, 0.00596) }, { 0.000824224d, new GammaParticle(214900.0, 0.00577) }, { 0.9584d, new GammaParticle(242800.0, 0.00511) }, { 0.057504d, new GammaParticle(612000.0, 0.00203) }, { 0.00268352d, new GammaParticle(620600.0, 0.002) }, { 0.055999999999999994d, new GammaParticle(2027.0, 0.61166) }, { 0.331d, new GammaParticle(14883.0, 0.08331) }, { 0.63d, new GammaParticle(14958.0, 0.08289) }, { 0.159d, new GammaParticle(16803.0, 0.07379) }, { 0.18100000000000002d, new GammaParticle(16880.0, 0.07345) }, { 0.022000000000000002d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    