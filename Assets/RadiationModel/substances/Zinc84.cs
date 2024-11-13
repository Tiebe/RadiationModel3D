
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc84 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc84";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 83.96583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium84() } },

        };
    }
}
    
    