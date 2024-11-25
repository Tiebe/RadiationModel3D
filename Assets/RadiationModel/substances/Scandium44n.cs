using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium44n : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 43.95956d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    