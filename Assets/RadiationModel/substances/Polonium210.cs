using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium210";
        public override double halfLife { get; } = 11955686.4d;
        public override double atomicWeight { get; } = 209.98287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6427447.4), new Lead206() } },

        };
    }
}
    
    