using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold205m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold205m";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 204.98104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    