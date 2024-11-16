using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oganesson294 : RadioactiveSubstance
    {
        public override string name { get; } = "Oganesson294";
        public override double halfLife { get; } = 0.0007d;
        public override double atomicWeight { get; } = 294.21398d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12885047.4), new Livermorium290() } },

        };
    }
}
    
    