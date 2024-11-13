
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium266";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 266.13706d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bohrium262() } },

        };
    }
}
    
    