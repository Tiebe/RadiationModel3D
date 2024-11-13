
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium229";
        public override double halfLife { get; } = 3762.0d;
        public override double atomicWeight { get; } = 229.03295d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thorium229() } },

        };
    }
}
    
    