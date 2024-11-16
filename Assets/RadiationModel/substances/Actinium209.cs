using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium209";
        public override double halfLife { get; } = 0.094d;
        public override double atomicWeight { get; } = 209.00949d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8745047.4), new Francium205() } },

        };
    }
}
    
    