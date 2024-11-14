using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium232";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 232.04974d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    