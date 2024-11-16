using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium241";
        public override double halfLife { get; } = 141.0d;
        public override double atomicWeight { get; } = 241.06369d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.15d, new List<RadioactiveSubstance> { new AlphaParticle(8675047.4), new Curium237() } },

        };
    }
}
    
    