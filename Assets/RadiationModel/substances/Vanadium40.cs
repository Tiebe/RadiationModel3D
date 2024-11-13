
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium40";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 40.01339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    