
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold195 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold195";
        public override double halfLife { get; } = 16071264.0d;
        public override double atomicWeight { get; } = 194.96504d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Platinum195() } },

        };
    }
}
    
    