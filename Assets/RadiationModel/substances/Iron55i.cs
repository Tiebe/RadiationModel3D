
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron55i : RadioactiveSubstance
    {
        public override string name { get; } = "Iron55i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 54.94649d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    