using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium87";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 86.96901d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14720000.0), new Germanium87() } },

        };
    }
}
    
    