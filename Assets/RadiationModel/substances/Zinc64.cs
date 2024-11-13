
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc64 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc64";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 63.92914d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    