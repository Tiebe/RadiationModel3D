
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum171 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum171";
        public override double halfLife { get; } = 1398.0d;
        public override double atomicWeight { get; } = 170.94448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium171() } },

        };
    }
}
    
    