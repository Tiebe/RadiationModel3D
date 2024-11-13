
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium174";
        public override double halfLife { get; } = 3.7d;
        public override double atomicWeight { get; } = 173.95076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium174() } },

        };
    }
}
    
    