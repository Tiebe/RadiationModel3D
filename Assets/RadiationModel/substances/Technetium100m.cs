using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium100m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium100m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 99.90787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((200700.0, 0.00618)), new Technetium100() } },

        };
    }
}
    
    