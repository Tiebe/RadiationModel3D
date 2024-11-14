using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium205";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 204.97443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    