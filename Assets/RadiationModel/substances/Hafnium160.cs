using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium160";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 159.95068d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.993d, new List<RadioactiveSubstance> { new BetaParticle(1, 4331000.0), new Lutetium160() } },
            { 0.006999999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(5924002.09), new Ytterbium156() } },

        };
    }
}
    
    