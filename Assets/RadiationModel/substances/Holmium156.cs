
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium156";
        public override double halfLife { get; } = 3360.0d;
        public override double atomicWeight { get; } = 155.92964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium156() } },

        };
    }
}
    
    