
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium230";
        public override double halfLife { get; } = 122.0d;
        public override double atomicWeight { get; } = 230.03633d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thorium230() } },

        };
    }
}
    
    