
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium266m : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium266m";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 266.13828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bohrium262() } },

        };
    }
}
    
    