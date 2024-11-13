
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium84";
        public override double halfLife { get; } = 0.0976d;
        public override double atomicWeight { get; } = 83.95266d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium84() } },

        };
    }
}
    
    