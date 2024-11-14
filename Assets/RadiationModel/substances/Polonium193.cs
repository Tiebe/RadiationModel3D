using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium193 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium193";
        public override double halfLife { get; } = 0.399d;
        public override double atomicWeight { get; } = 192.99106d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8114047.4), new Lead189() } },

        };
    }
}
    
    