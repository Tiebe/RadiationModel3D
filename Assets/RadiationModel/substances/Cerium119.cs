using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium119";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 118.95296d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    