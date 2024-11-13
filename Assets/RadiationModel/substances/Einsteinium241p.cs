
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium241p : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium241p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 241.06884d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    