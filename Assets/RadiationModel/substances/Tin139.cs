using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin139 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin139";
        public override double halfLife { get; } = 0.13d;
        public override double atomicWeight { get; } = 138.9578d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony139() }, { 1.0d, new BetaParticle(-1, 5370000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    