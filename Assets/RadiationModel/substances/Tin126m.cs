using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin126m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin126m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 125.91004d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    