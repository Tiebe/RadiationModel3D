using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium120";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 119.94662d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium120() }, { 1.0d, new BetaParticle(-1, 4450000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    