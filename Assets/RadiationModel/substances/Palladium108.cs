
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium108";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 107.90389d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    