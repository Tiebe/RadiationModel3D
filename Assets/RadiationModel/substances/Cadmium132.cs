
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium132";
        public override double halfLife { get; } = 0.084d;
        public override double atomicWeight { get; } = 131.94582d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium132() } },

        };
    }
}
    
    