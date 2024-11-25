using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium242";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 242.07343d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    