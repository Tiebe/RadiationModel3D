using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead205m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead205m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 204.97448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    