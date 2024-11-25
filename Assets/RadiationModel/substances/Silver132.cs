using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver132 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver132";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 131.96307d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium132() }, { 1.0d, new BetaParticle(-1, 8035000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    