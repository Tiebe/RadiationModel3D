
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium249";
        public override double halfLife { get; } = 11076490152.0d;
        public override double atomicWeight { get; } = 249.07485d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium245() } },

            { 5e-09d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    