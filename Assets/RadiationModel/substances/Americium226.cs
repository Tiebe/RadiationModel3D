
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium226";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 226.04613d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    