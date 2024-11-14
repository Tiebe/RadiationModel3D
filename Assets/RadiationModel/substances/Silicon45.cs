using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon45 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon45";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 45.03982d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    