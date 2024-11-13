
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium99";
        public override double halfLife { get; } = 1391040.0d;
        public override double atomicWeight { get; } = 98.90812d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium99() } },

        };
    }
}
    
    