using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium215";
        public override double halfLife { get; } = 0.171d;
        public override double atomicWeight { get; } = 215.00647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8768002.09), new Francium211() } },
            { 0.0009d, new List<RadioactiveSubstance> { new BetaParticle(1, 3499000.0), new Radium215() } },

        };
    }
}
    
    