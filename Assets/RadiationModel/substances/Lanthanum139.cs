using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum139 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum139";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 138.90636d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    