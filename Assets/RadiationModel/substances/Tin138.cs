using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin138 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin138";
        public override double halfLife { get; } = 0.14d;
        public override double atomicWeight { get; } = 137.95114d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony138() }, { 1.0d, new BetaParticle(-1, 4570000.0) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony138() }, { 1.0d, new BetaParticle(-1, 4570000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    