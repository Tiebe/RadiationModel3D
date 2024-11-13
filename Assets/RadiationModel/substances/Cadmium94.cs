
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium94";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 93.95659d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    