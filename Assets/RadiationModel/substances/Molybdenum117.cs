
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum117 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum117";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 116.96169d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium117() } },

        };
    }
}
    
    