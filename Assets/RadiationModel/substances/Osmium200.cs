using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium200";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 199.98009d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium200() }, { 1.0d, new BetaParticle(-1, 1510000.0) } } },

        };
    }
}
    