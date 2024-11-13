
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium278";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 278.16159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Meitnerium274() } },

        };
    }
}
    
    