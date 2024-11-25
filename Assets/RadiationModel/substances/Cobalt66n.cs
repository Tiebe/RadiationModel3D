using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt66n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt66n";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 65.94013d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    