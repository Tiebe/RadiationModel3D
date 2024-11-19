using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine213m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine213m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 212.99439d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00091, 1358000.0), new Astatine213() } },

        };
    }
}
    
    