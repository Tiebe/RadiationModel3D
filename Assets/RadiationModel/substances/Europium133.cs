
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium133";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 132.94929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    