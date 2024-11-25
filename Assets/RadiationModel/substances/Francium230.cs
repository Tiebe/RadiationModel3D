using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium230";
        public override double halfLife { get; } = 19.1d;
        public override double atomicWeight { get; } = 230.04239d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium230() }, { 1.0d, new BetaParticle(-1, 2485500.0) } } },

        };
    }
}
    