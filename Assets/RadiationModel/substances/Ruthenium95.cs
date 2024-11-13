
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium95";
        public override double halfLife { get; } = 5785.2d;
        public override double atomicWeight { get; } = 94.9104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium95() } },

        };
    }
}
    
    