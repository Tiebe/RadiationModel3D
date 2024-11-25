using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium125";
        public override double halfLife { get; } = 0.0265d;
        public override double atomicWeight { get; } = 124.95509d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium125() }, { 1.0d, new BetaParticle(-1, 6065000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    