using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon231 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon231";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 231.04997d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    