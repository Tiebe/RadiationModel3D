
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium240p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium240p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 240.06001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    