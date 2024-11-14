using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium162";
        public override double halfLife { get; } = 39.4d;
        public override double atomicWeight { get; } = 161.94722d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99992d, new List<RadioactiveSubstance> { new BetaParticle(1, 3662000.0), new Lutetium162() } },
            { 8e-05d, new List<RadioactiveSubstance> { new AlphaParticle(5437047.4), new Ytterbium158() } },

        };
    }
}
    
    