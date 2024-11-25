using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium233";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 233.05252d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium233() }, { 1.0d, new BetaParticle(-1, 2293000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    