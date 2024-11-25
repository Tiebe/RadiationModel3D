using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium232";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 232.04348d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium232() }, { 1.0d, new BetaParticle(-1, 671500.0) } } },

        };
    }
}
    