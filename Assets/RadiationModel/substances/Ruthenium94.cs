
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium94";
        public override double halfLife { get; } = 3108.0d;
        public override double atomicWeight { get; } = 93.91134d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium94() } },

        };
    }
}
    
    