using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium292 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium292";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 292.20197d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11805047.4), new Flerovium288() } },

        };
    }
}
    
    