
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium156";
        public override double halfLife { get; } = 83.8d;
        public override double atomicWeight { get; } = 155.93899d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium156() } },

            { 0.00064d, new List<RadioactiveSubstance> { new AlphaParticle(), new Holmium152() } },

        };
    }
}
    
    