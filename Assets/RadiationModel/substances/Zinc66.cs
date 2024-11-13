
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc66 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc66";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 65.92603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    