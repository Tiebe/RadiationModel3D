
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium171";
        public override double halfLife { get; } = 712540.8d;
        public override double atomicWeight { get; } = 170.93792d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium171() } },

        };
    }
}
    
    