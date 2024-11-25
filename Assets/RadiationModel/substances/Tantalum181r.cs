using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum181r : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181r";
        public override double halfLife { get; } = 0.00021d;
        public override double atomicWeight { get; } = 180.95039d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    