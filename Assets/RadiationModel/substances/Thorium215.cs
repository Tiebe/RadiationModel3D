using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium215";
        public override double halfLife { get; } = 1.35d;
        public override double atomicWeight { get; } = 215.01172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8686002.09), new Radium211() } },

        };
    }
}
    
    