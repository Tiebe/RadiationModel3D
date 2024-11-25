using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium265";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 265.11668d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    