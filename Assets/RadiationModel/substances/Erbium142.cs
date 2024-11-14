using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium142";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 141.97002d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    