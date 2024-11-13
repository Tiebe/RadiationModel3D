
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury200 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury200";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 199.96833d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    