using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium281";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 281.17371d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    