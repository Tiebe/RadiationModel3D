using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium160";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 159.92706d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    