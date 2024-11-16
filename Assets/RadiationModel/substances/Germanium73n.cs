using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium73n : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium73n";
        public override double halfLife { get; } = 0.499d;
        public override double atomicWeight { get; } = 72.92353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01858), new Germanium73() } },

        };
    }
}
    
    