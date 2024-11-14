using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium167";
        public override double halfLife { get; } = 0.839d;
        public override double atomicWeight { get; } = 166.97155d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new List<RadioactiveSubstance> { new AlphaParticle(7005047.4), new Tungsten163() } },

        };
    }
}
    
    