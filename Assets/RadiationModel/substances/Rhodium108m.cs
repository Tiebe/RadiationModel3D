
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium108m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium108m";
        public override double halfLife { get; } = 360.0d;
        public override double atomicWeight { get; } = 107.90884d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium108() } },

        };
    }
}
    
    