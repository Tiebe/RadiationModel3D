
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium177";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 176.95399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    