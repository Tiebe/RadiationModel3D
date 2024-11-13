
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium72m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium72m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 71.95896d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    