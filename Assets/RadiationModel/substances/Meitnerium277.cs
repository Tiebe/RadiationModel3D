
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium277";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 277.15353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    