
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium108";
        public override double halfLife { get; } = 5.17d;
        public override double atomicWeight { get; } = 107.91849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium108() } },

        };
    }
}
    
    