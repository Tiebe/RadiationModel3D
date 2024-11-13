
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium80";
        public override double halfLife { get; } = 6378.0d;
        public override double atomicWeight { get; } = 79.92452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium80() } },

        };
    }
}
    
    