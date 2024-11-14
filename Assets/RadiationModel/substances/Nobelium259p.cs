using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium259p : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium259p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 259.10125d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    