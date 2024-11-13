
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium182";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 181.95824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    