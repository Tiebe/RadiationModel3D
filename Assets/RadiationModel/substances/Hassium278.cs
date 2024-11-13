
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium278";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 278.15375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    