using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium163";
        public override double halfLife { get; } = 0.0057d;
        public override double atomicWeight { get; } = 162.98246d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7685047.4), new Tungsten159() } },

        };
    }
}
    
    