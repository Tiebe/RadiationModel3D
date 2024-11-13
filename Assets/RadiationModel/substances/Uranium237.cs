
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium237";
        public override double halfLife { get; } = 583372.8d;
        public override double atomicWeight { get; } = 237.04873d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neptunium237() } },

        };
    }
}
    
    