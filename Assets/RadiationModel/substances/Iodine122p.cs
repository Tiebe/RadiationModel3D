using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine122p : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122p";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 121.90801d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    