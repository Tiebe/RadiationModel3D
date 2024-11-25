using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium123";
        public override double halfLife { get; } = 0.019d;
        public override double atomicWeight { get; } = 122.96076d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium123() }, { 1.0d, new BetaParticle(-1, 6320000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    