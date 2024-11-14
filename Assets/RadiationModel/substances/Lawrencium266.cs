using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium266";
        public override double halfLife { get; } = 79200.0d;
        public override double atomicWeight { get; } = 266.11987d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    