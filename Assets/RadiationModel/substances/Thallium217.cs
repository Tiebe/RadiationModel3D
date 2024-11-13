
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium217";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 217.02003d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    