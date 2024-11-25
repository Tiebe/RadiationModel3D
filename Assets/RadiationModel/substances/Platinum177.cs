using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum177 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum177";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 176.96847d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.943d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium177() }, { 1.0d, new BetaParticle(1, 6293000.0) } } },
            { 0.057d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium173() }, { 1.0d, new AlphaParticle(6665002.09) }, { 5e-06d, new GammaParticle(91800.0, 0.01351) }, { 9.208738e-06d, new GammaParticle(10393.0, 0.1193) }, { 7.879964803663199e-06d, new GammaParticle(61486.0, 0.02016) }, { 1.3579122529145614e-05d, new GammaParticle(63000.0, 0.01968) }, { 4.543291146243116e-06d, new GammaParticle(71496.0, 0.01734) }, { 5.815412667191189e-06d, new GammaParticle(72338.0, 0.01714) }, { 1.2721215209480723e-06d, new GammaParticle(73364.0, 0.0169) } } },

        };
    }
}
    