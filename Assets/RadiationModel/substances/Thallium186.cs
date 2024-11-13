
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium186";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 185.97865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    