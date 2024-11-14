using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium77";
        public override double halfLife { get; } = 13.2d;
        public override double atomicWeight { get; } = 76.92915d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.12d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5220470.0), new Germanium77() } },
            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5060760.0), new Germanium77m() } },

        };
    }
}
    
    