
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium63";
        public override double halfLife { get; } = 32.4d;
        public override double atomicWeight { get; } = 62.93929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc63() } },

        };
    }
}
    
    