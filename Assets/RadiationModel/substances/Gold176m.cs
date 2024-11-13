
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold176m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold176m";
        public override double halfLife { get; } = 1.36d;
        public override double atomicWeight { get; } = 175.98027d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    