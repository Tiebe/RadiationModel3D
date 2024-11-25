using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium278p : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium278p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 278.15691d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    