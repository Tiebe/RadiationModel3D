
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium226";
        public override double halfLife { get; } = 48.5d;
        public override double atomicWeight { get; } = 226.02955d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium226() } },

        };
    }
}
    
    