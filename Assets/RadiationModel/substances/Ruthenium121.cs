using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium121";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 120.9521d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium121() }, { 1.0d, new BetaParticle(-1, 5815000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    