using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium166";
        public override double halfLife { get; } = 204120.0d;
        public override double atomicWeight { get; } = 165.93388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Thulium166() } },

        };
    }
}
    
    