
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium90";
        public override double halfLife { get; } = 49.2d;
        public override double atomicWeight { get; } = 89.92407d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum90() } },

        };
    }
}
    
    