
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium97";
        public override double halfLife { get; } = 245116.8d;
        public override double atomicWeight { get; } = 96.90755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium97() } },

        };
    }
}
    
    