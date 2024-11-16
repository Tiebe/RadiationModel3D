using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium216";
        public override double halfLife { get; } = 0.144d;
        public override double atomicWeight { get; } = 216.00191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7926247.4), new Lead212() } },

        };
    }
}
    
    