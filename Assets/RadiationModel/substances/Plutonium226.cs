using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium226";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 226.03825d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    