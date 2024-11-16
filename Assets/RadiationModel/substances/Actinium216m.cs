using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium216m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 216.00879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10299047.4), new Francium212() } },

        };
    }
}
    
    