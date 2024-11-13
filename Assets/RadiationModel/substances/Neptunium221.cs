
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium221";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 221.03211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    