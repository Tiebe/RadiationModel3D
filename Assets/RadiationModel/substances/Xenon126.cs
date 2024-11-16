using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon126 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon126";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 125.9043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    