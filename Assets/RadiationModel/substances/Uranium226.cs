using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium226";
        public override double halfLife { get; } = 0.269d;
        public override double atomicWeight { get; } = 226.02934d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8721047.4), new Thorium222() } },

        };
    }
}
    
    