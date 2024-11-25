using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur30 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur30";
        public override double halfLife { get; } = 1.1798d;
        public override double atomicWeight { get; } = 29.98491d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon30() }, { 1.0d, new BetaParticle(1, 5186856.0) }, { 0.784d, new GammaParticle(677100.0, 0.00183) }, { 0.0029d, new GammaParticle(708700.0, 0.00175) }, { 0.022799999999999997d, new GammaParticle(2342300.0, 0.00053) }, { 1.9991999999999999d, new GammaParticle(511000.0, 0.00243) }, { 9.207369704044799e-07d, new GammaParticle(149.0, 8.32109) }, { 1.3552735032972301e-05d, new GammaParticle(2013.0, 0.61592) }, { 2.6847731840277936e-05d, new GammaParticle(2014.0, 0.61561) }, { 1.7372200755497601e-06d, new GammaParticle(2138.0, 0.57991) }, { 1.7372200755497601e-06d, new GammaParticle(2138.0, 0.57991) } } },

        };
    }
}
    