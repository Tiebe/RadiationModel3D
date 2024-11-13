
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium71 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium71";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 70.9247d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    