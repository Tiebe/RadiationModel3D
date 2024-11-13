
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium154";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 153.96486d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium154() } },

            { 0.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Ytterbium150() } },

        };
    }
}
    
    