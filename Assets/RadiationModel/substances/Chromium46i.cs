using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium46i : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium46i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 45.97818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    