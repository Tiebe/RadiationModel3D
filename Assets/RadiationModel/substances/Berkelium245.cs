using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium245";
        public override double halfLife { get; } = 427680.0d;
        public override double atomicWeight { get; } = 245.06636d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9987999999999999d, new List<RadioactiveSubstance> { new Curium245() } },
            { 0.0012d, new List<RadioactiveSubstance> { new AlphaParticle(7474547.4), new Americium241() } },

        };
    }
}
    
    