using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium55";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 54.95509d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium55() }, { 1.0d, new BetaParticle(-1, 3646500.0) }, { 0.2d, new GammaParticle(323400.0, 0.00383) }, { 0.03d, new GammaParticle(349300.0, 0.00355) }, { 0.05d, new GammaParticle(651600.0, 0.0019) }, { 0.44d, new GammaParticle(672500.0, 0.00184) }, { 0.1d, new GammaParticle(828100.0, 0.0015) }, { 0.05d, new GammaParticle(1262500.0, 0.00098) }, { 0.12d, new GammaParticle(1330100.0, 0.00093) }, { 0.06d, new GammaParticle(1480000.0, 0.00084) }, { 0.05d, new GammaParticle(1830000.0, 0.00068) } } },

        };
    }
}
    