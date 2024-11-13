
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium266";
        public override double halfLife { get; } = 14400.0d;
        public override double atomicWeight { get; } = 266.11824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    