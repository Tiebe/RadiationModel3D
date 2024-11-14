using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium259";
        public override double halfLife { get; } = 5760.0d;
        public override double atomicWeight { get; } = 259.10044d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    