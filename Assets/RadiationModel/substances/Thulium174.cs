
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium174";
        public override double halfLife { get; } = 324.0d;
        public override double atomicWeight { get; } = 173.94218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium174() } },

        };
    }
}
    
    