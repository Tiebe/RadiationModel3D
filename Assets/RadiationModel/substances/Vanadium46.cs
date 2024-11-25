using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46";
        public override double halfLife { get; } = 0.4225d;
        public override double atomicWeight { get; } = 45.9602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium46() }, { 1.0d, new BetaParticle(1, 2342850.0) }, { 3.9e-05d, new GammaParticle(889000.0, 0.00139) }, { 3.9e-05d, new GammaParticle(1722000.0, 0.00072) }, { 0.000113d, new GammaParticle(4317000.0, 0.00029) }, { 1.998014d, new GammaParticle(511000.0, 0.00243) }, { 4.73836467437022e-06d, new GammaParticle(477.0, 2.59925) }, { 5.9479387279107523e-05d, new GammaParticle(4505.0, 0.27521) }, { 0.00011717767391471144d, new GammaParticle(4511.0, 0.27485) }, { 2.3407060608181012e-05d, new GammaParticle(4947.0, 0.25063) }, { 2.3407060608181012e-05d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    