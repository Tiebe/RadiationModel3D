using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon34 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon34";
        public override double halfLife { get; } = 0.8438d;
        public override double atomicWeight { get; } = 33.98027d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur34() }, { 1.0d, new BetaParticle(1, 5776700.0) }, { 0.009088500000000001d, new GammaParticle(460800.0, 0.00269) }, { 0.024900000000000002d, new GammaParticle(665800.0, 0.00186) }, { 0.0085905d, new GammaParticle(2579400.0, 0.00048) }, { 0.0129729d, new GammaParticle(3129000.0, 0.0004) }, { 1.9984d, new GammaParticle(511000.0, 0.00243) }, { 1.734675521196998e-06d, new GammaParticle(223.0, 5.55983) }, { 2.434877761014723e-05d, new GammaParticle(2621.0, 0.47304) }, { 4.815818356437348e-05d, new GammaParticle(2623.0, 0.47268) }, { 6.2355986610087805e-06d, new GammaParticle(2816.0, 0.44028) }, { 6.2355986610087805e-06d, new GammaParticle(2816.0, 0.44028) } } },

        };
    }
}
    