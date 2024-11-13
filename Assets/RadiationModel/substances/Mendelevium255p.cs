
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium255p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium255p";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 255.09109d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    