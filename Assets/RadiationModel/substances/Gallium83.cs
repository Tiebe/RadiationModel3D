using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium83";
        public override double halfLife { get; } = 0.31d;
        public override double atomicWeight { get; } = 82.94712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11719300.0), new Germanium83() } },

        };
    }
}
    
    