using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium233p : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium233p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 233.04079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    