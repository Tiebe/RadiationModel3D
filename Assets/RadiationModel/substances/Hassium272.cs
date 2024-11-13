
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium272";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 272.13849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    