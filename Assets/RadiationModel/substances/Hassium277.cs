
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium277";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 277.15178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    