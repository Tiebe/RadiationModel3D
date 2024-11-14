using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium72 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium72";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 71.92208d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    