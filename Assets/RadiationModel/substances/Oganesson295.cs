using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oganesson295 : RadioactiveSubstance
    {
        public override string name { get; } = "Oganesson295";
        public override double halfLife { get; } = 0.68d;
        public override double atomicWeight { get; } = 295.21618d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12727002.09), new Livermorium291() } },

        };
    }
}
    
    