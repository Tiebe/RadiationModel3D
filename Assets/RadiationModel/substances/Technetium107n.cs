using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium107n : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium107n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 106.91553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01879), new Technetium107() } },

        };
    }
}
    
    