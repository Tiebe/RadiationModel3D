using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine69n : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine69n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 68.95095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    