using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony139 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony139";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 138.94627d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium139() }, { 1.0d, new BetaParticle(-1, 5077500.0) } } },
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium139() }, { 1.0d, new BetaParticle(-1, 5077500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    