using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead205 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead205";
        public override double halfLife { get; } = 536468184000000.0d;
        public override double atomicWeight { get; } = 204.97448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Thallium205() } },

        };
    }
}
    
    