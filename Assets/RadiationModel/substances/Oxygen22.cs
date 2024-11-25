using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen22 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen22";
        public override double halfLife { get; } = 2.25d;
        public override double atomicWeight { get; } = 22.00996d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine22() }, { 1.0d, new BetaParticle(-1, 3243500.0) }, { 1.02d, new GammaParticle(71600.0, 0.01732) }, { 1.0d, new GammaParticle(637400.0, 0.00195) }, { 0.13d, new GammaParticle(709600.0, 0.00175) }, { 0.34d, new GammaParticle(918000.0, 0.00135) }, { 0.03d, new GammaParticle(944000.0, 0.00131) }, { 0.63d, new GammaParticle(1862600.0, 0.00067) }, { 0.09d, new GammaParticle(1874200.0, 0.00066) }, { 0.015d, new GammaParticle(2499000.0, 0.0005) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine22() }, { 1.0d, new BetaParticle(-1, 3243500.0) }, { 1.02d, new GammaParticle(71600.0, 0.01732) }, { 1.0d, new GammaParticle(637400.0, 0.00195) }, { 0.13d, new GammaParticle(709600.0, 0.00175) }, { 0.34d, new GammaParticle(918000.0, 0.00135) }, { 0.03d, new GammaParticle(944000.0, 0.00131) }, { 0.63d, new GammaParticle(1862600.0, 0.00067) }, { 0.09d, new GammaParticle(1874200.0, 0.00066) }, { 0.015d, new GammaParticle(2499000.0, 0.0005) } } },

        };
    }
}
    