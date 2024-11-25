using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine26 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine26";
        public override double halfLife { get; } = 0.0082d;
        public override double atomicWeight { get; } = 26.02004d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon26() }, { 1.0d, new BetaParticle(-1, 9094500.0) }, { 0.12d, new GammaParticle(1672750.0, 0.00074) }, { 0.023d, new GammaParticle(1797100.0, 0.00069) }, { 0.5d, new GammaParticle(2017900.0, 0.00061) }, { 8.61689994570136e-09d, new GammaParticle(848.0, 1.46208) }, { 1.7137828054298646e-08d, new GammaParticle(848.0, 1.46208) } } },
            { 0.135d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon26() }, { 1.0d, new BetaParticle(-1, 9094500.0) }, { 0.12d, new GammaParticle(1672750.0, 0.00074) }, { 0.023d, new GammaParticle(1797100.0, 0.00069) }, { 0.5d, new GammaParticle(2017900.0, 0.00061) }, { 8.61689994570136e-09d, new GammaParticle(848.0, 1.46208) }, { 1.7137828054298646e-08d, new GammaParticle(848.0, 1.46208) } } },

        };
    }
}
    