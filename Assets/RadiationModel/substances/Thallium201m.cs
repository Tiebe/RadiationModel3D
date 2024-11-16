using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium201m";
        public override double halfLife { get; } = 0.00201d;
        public override double atomicWeight { get; } = 200.97181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((919000.0, 0.00135)), new Thallium201() } },

        };
    }
}
    
    