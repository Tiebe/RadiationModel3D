using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium289";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 289.18846d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    