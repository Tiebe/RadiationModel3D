
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium117";
        public override double halfLife { get; } = 0.0445d;
        public override double atomicWeight { get; } = 116.94832d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium117() } },

        };
    }
}
    
    