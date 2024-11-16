using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium256p : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium256p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 256.09874d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    