
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium201";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 200.98407d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    