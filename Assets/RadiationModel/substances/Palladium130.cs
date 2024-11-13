
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium130";
        public override double halfLife { get; } = 0.027d;
        public override double atomicWeight { get; } = 129.96486d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    