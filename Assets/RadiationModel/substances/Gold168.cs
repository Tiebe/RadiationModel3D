using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold168 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold168";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 168.00272d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    