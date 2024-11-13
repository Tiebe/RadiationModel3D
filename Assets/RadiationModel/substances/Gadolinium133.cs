
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium133";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 132.96129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    