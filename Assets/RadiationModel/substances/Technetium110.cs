
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium110";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 109.92374d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium110() } },

        };
    }
}
    
    