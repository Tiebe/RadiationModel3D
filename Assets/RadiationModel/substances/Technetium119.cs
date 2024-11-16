using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium119";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 118.95688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11910000.0), new Ruthenium119() } },

        };
    }
}
    
    