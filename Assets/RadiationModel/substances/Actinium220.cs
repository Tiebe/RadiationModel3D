using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium220";
        public override double halfLife { get; } = 0.02636d;
        public override double atomicWeight { get; } = 220.01475d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9370002.09), new Francium216() } },

        };
    }
}
    
    