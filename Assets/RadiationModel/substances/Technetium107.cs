
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium107";
        public override double halfLife { get; } = 21.2d;
        public override double atomicWeight { get; } = 106.91546d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium107() } },

        };
    }
}
    
    