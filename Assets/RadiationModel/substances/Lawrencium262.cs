
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium262";
        public override double halfLife { get; } = 14400.0d;
        public override double atomicWeight { get; } = 262.10962d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.1d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    