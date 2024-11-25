using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium234m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium234m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 234.04829d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    