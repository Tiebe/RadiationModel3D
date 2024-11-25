using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium45";
        public override double halfLife { get; } = 0.547d;
        public override double atomicWeight { get; } = 44.96577d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium45() }, { 1.0d, new BetaParticle(1, 4592950.0) }, { 0.035d, new GammaParticle(40100.0, 0.03092) }, { 1.9980000000000002d, new GammaParticle(511000.0, 0.00243) }, { 4.236725512566e-05d, new GammaParticle(477.0, 2.59925) }, { 0.0005338077935461652d, new GammaParticle(4505.0, 0.27521) }, { 0.001051630798948316d, new GammaParticle(4511.0, 0.27485) }, { 0.00021007061350551874d, new GammaParticle(4947.0, 0.25063) }, { 0.00021007061350551874d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    