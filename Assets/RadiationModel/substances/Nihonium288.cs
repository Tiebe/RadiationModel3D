using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium288 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium288";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 288.18676d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    