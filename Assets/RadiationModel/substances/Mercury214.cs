using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury214 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury214";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 214.01264d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    