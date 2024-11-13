
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt49 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt49";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 48.9895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    