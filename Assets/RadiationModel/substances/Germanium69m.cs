using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium69m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium69m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 68.92806d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01428, 86800.0), new Germanium69() } },

        };
    }
}
    
    