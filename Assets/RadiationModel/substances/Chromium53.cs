
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium53";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 52.94065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    