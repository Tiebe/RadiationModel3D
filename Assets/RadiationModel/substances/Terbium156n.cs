using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium156n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium156n";
        public override double halfLife { get; } = 87840.0d;
        public override double atomicWeight { get; } = 155.92486d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    