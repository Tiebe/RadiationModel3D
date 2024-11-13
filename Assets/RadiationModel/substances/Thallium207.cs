
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium207";
        public override double halfLife { get; } = 286.2d;
        public override double atomicWeight { get; } = 206.97742d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead207() } },

        };
    }
}
    
    