
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium62";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 62.00785d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    