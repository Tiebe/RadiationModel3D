using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium268";
        public override double halfLife { get; } = 190.0d;
        public override double atomicWeight { get; } = 268.12959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    