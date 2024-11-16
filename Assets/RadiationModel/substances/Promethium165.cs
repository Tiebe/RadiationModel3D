using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium165";
        public override double halfLife { get; } = 0.26d;
        public override double atomicWeight { get; } = 164.96278d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    