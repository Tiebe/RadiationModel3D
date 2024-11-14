using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium88";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 87.97596d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    