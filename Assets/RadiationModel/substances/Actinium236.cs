
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium236";
        public override double halfLife { get; } = 270.0d;
        public override double atomicWeight { get; } = 236.05499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thorium236() } },

        };
    }
}
    
    