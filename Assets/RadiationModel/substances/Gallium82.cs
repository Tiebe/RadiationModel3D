using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium82";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 81.94318d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12484400.0), new Germanium82() } },

        };
    }
}
    
    