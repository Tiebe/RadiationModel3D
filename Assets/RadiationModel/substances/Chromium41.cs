
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium41";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 41.02191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    