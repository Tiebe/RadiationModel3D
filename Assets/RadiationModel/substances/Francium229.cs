
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium229";
        public override double halfLife { get; } = 50.2d;
        public override double atomicWeight { get; } = 229.03829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium229() } },

        };
    }
}
    
    