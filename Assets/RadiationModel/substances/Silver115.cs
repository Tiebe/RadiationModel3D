
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver115 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver115";
        public override double halfLife { get; } = 1200.0d;
        public override double atomicWeight { get; } = 114.90877d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium115() } },

        };
    }
}
    
    