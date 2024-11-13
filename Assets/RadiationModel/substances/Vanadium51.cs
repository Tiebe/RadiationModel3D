
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium51";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 50.94396d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    