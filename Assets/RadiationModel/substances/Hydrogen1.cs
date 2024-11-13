
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hydrogen1 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen1";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 1.00783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    