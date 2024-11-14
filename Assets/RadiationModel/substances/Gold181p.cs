using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold181p : RadioactiveSubstance
    {
        public override string name { get; } = "Gold181p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 180.97031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    