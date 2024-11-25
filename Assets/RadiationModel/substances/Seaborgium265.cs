using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium265";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 265.12109d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    