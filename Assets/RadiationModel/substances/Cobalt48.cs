
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt48 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt48";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 48.00186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    