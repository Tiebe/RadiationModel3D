using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium137";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 136.92048d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    