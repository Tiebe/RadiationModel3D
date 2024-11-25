using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon29 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon29";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 29.01975d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium29() }, { 1.0d, new BetaParticle(-1, 7860000.0) }, { 0.54d, new GammaParticle(72000.0, 0.01722) }, { 0.102d, new GammaParticle(223800.0, 0.00554) }, { 0.05d, new GammaParticle(1176500.0, 0.00105) }, { 0.12d, new GammaParticle(1249000.0, 0.00099) }, { 0.16d, new GammaParticle(1516000.0, 0.00082) }, { 0.11d, new GammaParticle(1588000.0, 0.00078) }, { 0.05d, new GammaParticle(2578000.0, 0.00048) }, { 0.13d, new GammaParticle(2822400.0, 0.00044) }, { 0.035d, new GammaParticle(2918200.0, 0.00042) }, { 0.012d, new GammaParticle(4094000.0, 0.0003) }, { 0.028999999999999998d, new GammaParticle(4166000.0, 0.0003) } } },
            { 0.28d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium29() }, { 1.0d, new BetaParticle(-1, 7860000.0) }, { 0.54d, new GammaParticle(72000.0, 0.01722) }, { 0.102d, new GammaParticle(223800.0, 0.00554) }, { 0.05d, new GammaParticle(1176500.0, 0.00105) }, { 0.12d, new GammaParticle(1249000.0, 0.00099) }, { 0.16d, new GammaParticle(1516000.0, 0.00082) }, { 0.11d, new GammaParticle(1588000.0, 0.00078) }, { 0.05d, new GammaParticle(2578000.0, 0.00048) }, { 0.13d, new GammaParticle(2822400.0, 0.00044) }, { 0.035d, new GammaParticle(2918200.0, 0.00042) }, { 0.012d, new GammaParticle(4094000.0, 0.0003) }, { 0.028999999999999998d, new GammaParticle(4166000.0, 0.0003) } } },
            { 0.04d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium27() }, { 1.0d, new BetaParticle(-1, 943453103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    