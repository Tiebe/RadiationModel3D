
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium250";
        public override double halfLife { get; } = 261922701600.0d;
        public override double atomicWeight { get; } = 250.07836d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.74d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    