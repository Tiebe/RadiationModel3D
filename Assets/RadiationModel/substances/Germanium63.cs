using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium63";
        public override double halfLife { get; } = 0.1536d;
        public override double atomicWeight { get; } = 62.94963d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9627100.0), new Gallium63() } },

        };
    }
}
    
    