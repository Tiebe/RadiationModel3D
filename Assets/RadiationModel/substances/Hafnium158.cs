
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium158";
        public override double halfLife { get; } = 2.85d;
        public override double atomicWeight { get; } = 157.9548d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.557d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium158() } },

            { 0.44299999999999995d, new List<RadioactiveSubstance> { new AlphaParticle(), new Ytterbium154() } },

        };
    }
}
    
    