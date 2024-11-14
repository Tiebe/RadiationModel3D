using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium238m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium238m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 238.05342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    