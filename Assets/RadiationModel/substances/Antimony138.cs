using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony138 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony138";
        public override double halfLife { get; } = 0.348d;
        public override double atomicWeight { get; } = 137.94133d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.72d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium138() }, { 1.0d, new BetaParticle(-1, 5523000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    