using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium257m : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium257m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 257.09959d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    