using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead200 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead200";
        public override double halfLife { get; } = 77400.0d;
        public override double atomicWeight { get; } = 199.97182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Thallium200() } },

        };
    }
}
    
    