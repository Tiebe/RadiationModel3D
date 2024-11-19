using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium259";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 259.10949d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10640002.09), new Lawrencium255() } },

        };
    }
}
    
    