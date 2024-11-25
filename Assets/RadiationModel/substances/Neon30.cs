using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon30 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon30";
        public override double halfLife { get; } = 0.00718d;
        public override double atomicWeight { get; } = 30.02499d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium30() }, { 1.0d, new BetaParticle(-1, 7402500.0) }, { 0.78d, new GammaParticle(150600.0, 0.00823) }, { 0.09d, new GammaParticle(365500.0, 0.00339) }, { 0.063d, new GammaParticle(410000.0, 0.00302) }, { 0.013999999999999999d, new GammaParticle(775000.0, 0.0016) }, { 0.05d, new GammaParticle(1597000.0, 0.00078) }, { 0.05d, new GammaParticle(1963000.0, 0.00063) }, { 0.04d, new GammaParticle(2114000.0, 0.00059) }, { 3.30783753287872e-05d, new GammaParticle(1041.0, 1.19101) }, { 6.577525418331119e-05d, new GammaParticle(1041.0, 1.19101) } } },
            { 0.126d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium30() }, { 1.0d, new BetaParticle(-1, 7402500.0) }, { 0.78d, new GammaParticle(150600.0, 0.00823) }, { 0.09d, new GammaParticle(365500.0, 0.00339) }, { 0.063d, new GammaParticle(410000.0, 0.00302) }, { 0.013999999999999999d, new GammaParticle(775000.0, 0.0016) }, { 0.05d, new GammaParticle(1597000.0, 0.00078) }, { 0.05d, new GammaParticle(1963000.0, 0.00063) }, { 0.04d, new GammaParticle(2114000.0, 0.00059) }, { 3.30783753287872e-05d, new GammaParticle(1041.0, 1.19101) }, { 6.577525418331119e-05d, new GammaParticle(1041.0, 1.19101) } } },
            { 0.08900000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium28() }, { 1.0d, new BetaParticle(-1, 943628103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    