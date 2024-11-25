using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt64m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt64m";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 63.93592d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    