using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium262";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 262.10992d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    