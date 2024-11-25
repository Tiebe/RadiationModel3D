using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel74 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel74";
        public override double halfLife { get; } = 0.5077d;
        public override double atomicWeight { get; } = 73.94772d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper74() }, { 1.0d, new BetaParticle(-1, 3653000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    