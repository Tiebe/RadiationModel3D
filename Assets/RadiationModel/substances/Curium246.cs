
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium246";
        public override double halfLife { get; } = 148507016112.00003d;
        public override double atomicWeight { get; } = 246.06722d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9997385d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium242() } },

            { 0.0002615d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    