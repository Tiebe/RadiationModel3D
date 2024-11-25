using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium180n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium180n";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 179.95055d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    