using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium271m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium271m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 271.14602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    