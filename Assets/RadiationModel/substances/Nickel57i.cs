
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel57i : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel57i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 56.94542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    