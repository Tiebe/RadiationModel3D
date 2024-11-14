using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium241";
        public override double halfLife { get; } = 1680.0d;
        public override double atomicWeight { get; } = 241.06413d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    