using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium167";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 166.96207d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    