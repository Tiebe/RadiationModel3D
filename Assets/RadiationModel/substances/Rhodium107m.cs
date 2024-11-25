using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium107m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium107m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 106.90704d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    