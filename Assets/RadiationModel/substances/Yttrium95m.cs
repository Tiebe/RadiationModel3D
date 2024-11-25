using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium95m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 94.91399d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    