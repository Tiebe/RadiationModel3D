
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium160";
        public override double halfLife { get; } = 564.0d;
        public override double atomicWeight { get; } = 159.93527d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium160() } },

        };
    }
}
    
    