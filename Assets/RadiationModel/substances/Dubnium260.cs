using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium260";
        public override double halfLife { get; } = 1.52d;
        public override double atomicWeight { get; } = 260.11129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.904d, new List<RadioactiveSubstance> { new AlphaParticle(10515047.4), new Lawrencium256() } },
            { 0.096d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    