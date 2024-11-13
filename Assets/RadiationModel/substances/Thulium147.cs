
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium147";
        public override double halfLife { get; } = 0.58d;
        public override double atomicWeight { get; } = 146.96138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.85d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium147() } },

            { 0.15d, new List<RadioactiveSubstance> { new ProtonParticle(), new Erbium146() } },

        };
    }
}
    
    