
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium253p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium253p";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 253.0872d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    