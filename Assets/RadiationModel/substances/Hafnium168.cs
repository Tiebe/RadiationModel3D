using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium168";
        public override double halfLife { get; } = 1557.0d;
        public override double atomicWeight { get; } = 167.94057d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1709000.0), new Lutetium168() } },
            { 0.98d, new List<RadioactiveSubstance> { new Lutetium168() } },
            { 0.02d, new List<RadioactiveSubstance> { new BetaParticle(1, 1709000.0), new Lutetium168() } },

        };
    }
}
    
    