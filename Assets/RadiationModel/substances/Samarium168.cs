using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium168";
        public override double halfLife { get; } = 0.34d;
        public override double atomicWeight { get; } = 167.96603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    