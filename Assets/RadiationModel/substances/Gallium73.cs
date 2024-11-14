using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium73 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium73";
        public override double halfLife { get; } = 17496.0d;
        public override double atomicWeight { get; } = 72.92517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1598230.0), new Germanium73() } },

        };
    }
}
    
    