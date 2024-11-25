using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium125";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 124.94207d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver125() }, { 1.0d, new BetaParticle(-1, 5280000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    