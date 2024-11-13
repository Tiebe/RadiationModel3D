
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium147m";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 146.95007d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium147() } },

        };
    }
}
    
    