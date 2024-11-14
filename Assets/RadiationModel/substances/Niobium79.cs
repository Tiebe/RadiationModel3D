using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium79";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 78.96602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    