using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium257m : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium257m";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 257.10767d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new AlphaParticle(10367002.09), new Lawrencium253() } },
            { 0.13d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    