
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium119m";
        public override double halfLife { get; } = 0.003d;
        public override double atomicWeight { get; } = 118.92366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    