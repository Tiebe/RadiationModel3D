
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium226";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 226.04031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    