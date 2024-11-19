using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine216m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine216m";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 216.00259d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9131902.09), new Bismuth212() } },

        };
    }
}
    
    