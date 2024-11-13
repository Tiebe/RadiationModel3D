
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold169 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold169";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 168.99808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    