using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen10 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen10";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 10.04165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    