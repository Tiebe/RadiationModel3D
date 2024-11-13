
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium86";
        public override double halfLife { get; } = 0.049d;
        public override double atomicWeight { get; } = 85.96376d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium86() } },

        };
    }
}
    
    