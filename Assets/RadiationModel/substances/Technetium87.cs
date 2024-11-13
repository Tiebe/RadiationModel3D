
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium87";
        public override double halfLife { get; } = 2.14d;
        public override double atomicWeight { get; } = 86.93807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum87() } },

        };
    }
}
    
    