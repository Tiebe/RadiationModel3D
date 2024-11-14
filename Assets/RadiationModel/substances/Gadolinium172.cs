using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium172";
        public override double halfLife { get; } = 0.16d;
        public override double atomicWeight { get; } = 171.96461d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    