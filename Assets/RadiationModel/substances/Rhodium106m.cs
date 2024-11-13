
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium106m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium106m";
        public override double halfLife { get; } = 7860.0d;
        public override double atomicWeight { get; } = 105.90743d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium106() } },

        };
    }
}
    
    