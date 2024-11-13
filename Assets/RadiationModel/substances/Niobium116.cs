
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium116";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 115.97291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    