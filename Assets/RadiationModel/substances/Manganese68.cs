
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese68 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese68";
        public override double halfLife { get; } = 0.0337d;
        public override double atomicWeight { get; } = 67.96895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron68() } },

        };
    }
}
    
    