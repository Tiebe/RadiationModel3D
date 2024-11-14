using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hydrogen6 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen6";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 6.04496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    