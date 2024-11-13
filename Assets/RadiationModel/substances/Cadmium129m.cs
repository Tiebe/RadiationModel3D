
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium129m";
        public override double halfLife { get; } = 0.157d;
        public override double atomicWeight { get; } = 128.9326d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium129() } },

        };
    }
}
    
    