using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium263";
        public override double halfLife { get; } = 18000.0d;
        public override double atomicWeight { get; } = 263.11129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    