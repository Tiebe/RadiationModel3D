
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese53i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese53i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 52.94877d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    