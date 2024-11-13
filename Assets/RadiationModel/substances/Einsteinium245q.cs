
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium245q : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium245q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 245.07154d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    