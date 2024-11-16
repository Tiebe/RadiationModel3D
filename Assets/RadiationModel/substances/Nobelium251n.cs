using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium251n : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium251n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 251.09016d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    