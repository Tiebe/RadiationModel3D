
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum112 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum112";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 111.93829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium112() } },

        };
    }
}
    
    