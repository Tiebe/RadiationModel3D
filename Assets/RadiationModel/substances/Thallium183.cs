
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium183";
        public override double halfLife { get; } = 6.9d;
        public override double atomicWeight { get; } = 182.98219d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    