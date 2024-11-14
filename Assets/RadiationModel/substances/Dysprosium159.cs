using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium159";
        public override double halfLife { get; } = 12476160.0d;
        public override double atomicWeight { get; } = 158.92575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Terbium159() } },

        };
    }
}
    
    