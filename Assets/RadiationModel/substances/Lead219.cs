using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead219 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead219";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 219.02214d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    