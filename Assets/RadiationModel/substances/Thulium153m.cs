
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium153m";
        public override double halfLife { get; } = 2.5d;
        public override double atomicWeight { get; } = 152.9421d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.92d, new List<RadioactiveSubstance> { new AlphaParticle(), new Holmium149() } },

            { 0.08d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium153() } },

        };
    }
}
    
    