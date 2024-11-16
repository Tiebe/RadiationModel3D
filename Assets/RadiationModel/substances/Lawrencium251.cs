using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium251";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 251.09429d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    