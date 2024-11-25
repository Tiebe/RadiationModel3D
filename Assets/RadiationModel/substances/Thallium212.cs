using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium212";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 211.99834d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead212() }, { 1.0d, new BetaParticle(-1, 2999450.0) }, { 0.1067d, new GammaParticle(157000.0, 0.0079) }, { 0.7663d, new GammaParticle(315000.0, 0.00394) }, { 0.97d, new GammaParticle(804000.0, 0.00154) }, { 0.057571372682d, new GammaParticle(12522.0, 0.09901) }, { 0.023267066222876907d, new GammaParticle(72805.0, 0.01703) }, { 0.03910431297962505d, new GammaParticle(74970.0, 0.01654) }, { 0.013365295543393276d, new GammaParticle(84986.0, 0.01459) }, { 0.017401614797498046d, new GammaParticle(86022.0, 0.01441) }, { 0.004036319254104769d, new GammaParticle(87301.0, 0.0142) } } },
            { 0.018000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead212() }, { 1.0d, new BetaParticle(-1, 2999450.0) }, { 0.1067d, new GammaParticle(157000.0, 0.0079) }, { 0.7663d, new GammaParticle(315000.0, 0.00394) }, { 0.97d, new GammaParticle(804000.0, 0.00154) }, { 0.057571372682d, new GammaParticle(12522.0, 0.09901) }, { 0.023267066222876907d, new GammaParticle(72805.0, 0.01703) }, { 0.03910431297962505d, new GammaParticle(74970.0, 0.01654) }, { 0.013365295543393276d, new GammaParticle(84986.0, 0.01459) }, { 0.017401614797498046d, new GammaParticle(86022.0, 0.01441) }, { 0.004036319254104769d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    