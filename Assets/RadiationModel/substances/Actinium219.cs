using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium219";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 219.01242d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9847047.4), new Francium215() } },

        };
    }
}
    
    