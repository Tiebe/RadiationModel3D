
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium67";
        public override double halfLife { get; } = 1134.0d;
        public override double atomicWeight { get; } = 66.93272d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium67() } },

        };
    }
}
    
    