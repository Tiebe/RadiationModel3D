
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium158";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 157.94932d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9909d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium158() } },

            { 0.0091d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thulium154() } },

        };
    }
}
    
    