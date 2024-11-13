
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium23 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium23";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 22.98977d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    