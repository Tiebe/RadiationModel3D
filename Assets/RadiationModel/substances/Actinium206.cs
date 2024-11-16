using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium206";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 206.01447d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8975002.09), new Francium202() } },

        };
    }
}
    
    