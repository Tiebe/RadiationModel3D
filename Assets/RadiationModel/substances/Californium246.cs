
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium246";
        public override double halfLife { get; } = 128520.0d;
        public override double atomicWeight { get; } = 246.0688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium242() } },

            { 2.4e-06d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    