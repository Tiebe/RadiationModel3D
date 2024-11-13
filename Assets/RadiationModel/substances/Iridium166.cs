
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium166";
        public override double halfLife { get; } = 0.0105d;
        public override double atomicWeight { get; } = 165.98571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.93d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium162() } },

            { 0.07d, new List<RadioactiveSubstance> { new ProtonParticle(), new Osmium165() } },

        };
    }
}
    
    