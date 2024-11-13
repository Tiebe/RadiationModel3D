
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium94";
        public override double halfLife { get; } = 17580.0d;
        public override double atomicWeight { get; } = 93.90965d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum94() } },

        };
    }
}
    
    