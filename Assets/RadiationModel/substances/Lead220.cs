
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead220 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead220";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 220.0259d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    