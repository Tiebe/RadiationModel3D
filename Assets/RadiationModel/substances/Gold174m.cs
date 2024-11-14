using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold174m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold174m";
        public override double halfLife { get; } = 0.162d;
        public override double atomicWeight { get; } = 173.98505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    