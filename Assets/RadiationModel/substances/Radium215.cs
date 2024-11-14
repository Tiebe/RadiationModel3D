using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215";
        public override double halfLife { get; } = 0.00167d;
        public override double atomicWeight { get; } = 215.00272d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9882047.4), new Radon211() } },

        };
    }
}
    
    