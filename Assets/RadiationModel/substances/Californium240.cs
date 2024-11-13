
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium240";
        public override double halfLife { get; } = 40.3d;
        public override double atomicWeight { get; } = 240.06225d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.985d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium236() } },

            { 0.015d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    