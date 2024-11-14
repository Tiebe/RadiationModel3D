using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium156";
        public override double halfLife { get; } = 26.1d;
        public override double atomicWeight { get; } = 155.94282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new BetaParticle(1, 3568000.0), new Thulium156() } },
            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(5829047.4), new Erbium152() } },

        };
    }
}
    
    