using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium21 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium21";
        public override double halfLife { get; } = 0.122d;
        public override double atomicWeight { get; } = 21.01171d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon21() }, { 1.0d, new BetaParticle(1, 8317840.0) }, { 0.51d, new GammaParticle(331910.0, 0.00374) }, { 0.10099999999999999d, new GammaParticle(1384100.0, 0.0009) }, { 0.0076d, new GammaParticle(1715900.0, 0.00072) }, { 7e-06d, new GammaParticle(1828000.0, 0.00068) }, { 2e-06d, new GammaParticle(3212100.0, 0.00039) }, { 0.0001d, new GammaParticle(3544000.0, 0.00035) }, { 1.9464259999999998d, new GammaParticle(511000.0, 0.00243) }, { 3.679904098473218e-07d, new GammaParticle(1041.0, 1.19101) }, { 1.8506237711221814e-07d, new GammaParticle(1041.0, 1.19101) } } },
            { 0.326d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon20() }, { 1.0d, new BetaParticle(1, 474719967.836) }, { 1.0d, new ProtonParticle() } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium21() }, { 1.0d, new BetaParticle(1, 6544380.0) } } },

        };
    }
}
    