using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium248";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 248.08662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    