using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium187";
        public override double halfLife { get; } = 1.3664148946998336e+18d;
        public override double atomicWeight { get; } = 186.95575d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium187() }, { 1.0d, new BetaParticle(-1, 1250.0) } } },
            { 1e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum183() }, { 1.0d, new AlphaParticle(2674002.09) } } },

        };
    }
}
    