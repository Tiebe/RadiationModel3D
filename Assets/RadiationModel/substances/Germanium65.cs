
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium65";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 64.93937d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium65() } },

        };
    }
}
    
    