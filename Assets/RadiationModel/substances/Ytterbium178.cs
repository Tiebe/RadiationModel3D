using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium178";
        public override double halfLife { get; } = 4440.0d;
        public override double atomicWeight { get; } = 177.94667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 660900.0), new Lutetium178() } },

        };
    }
}
    
    