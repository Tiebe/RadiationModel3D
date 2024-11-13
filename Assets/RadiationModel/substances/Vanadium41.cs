
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium41";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 41.00033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    