using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium237";
        public override double halfLife { get; } = 23.0d;
        public override double atomicWeight { get; } = 237.05799d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    