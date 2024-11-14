using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium50";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 49.94604d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    