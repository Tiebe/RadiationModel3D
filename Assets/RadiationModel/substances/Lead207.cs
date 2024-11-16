using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead207 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead207";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 206.9759d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    