using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine214m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine214m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 213.99643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10067902.09), new Bismuth210() } },

        };
    }
}
    
    