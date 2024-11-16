using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium229p : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium229p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 229.03646d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    