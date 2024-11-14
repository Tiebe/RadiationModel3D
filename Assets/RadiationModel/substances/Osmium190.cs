using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium190";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 189.95845d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    