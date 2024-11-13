
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt57i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt57i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 56.94408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    