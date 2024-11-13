
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium215";
        public override double halfLife { get; } = 9.7d;
        public override double atomicWeight { get; } = 215.01077d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead215() } },

        };
    }
}
    
    