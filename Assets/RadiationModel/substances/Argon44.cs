
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon44 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon44";
        public override double halfLife { get; } = 712.2d;
        public override double atomicWeight { get; } = 43.96492d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Potassium44() } },

        };
    }
}
    
    