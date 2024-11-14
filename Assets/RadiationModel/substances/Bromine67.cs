using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine67 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine67";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 66.96508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    