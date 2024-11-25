using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum156 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum156";
        public override double halfLife { get; } = 0.084d;
        public override double atomicWeight { get; } = 155.96452d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium156() }, { 1.0d, new BetaParticle(-1, 5885000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    