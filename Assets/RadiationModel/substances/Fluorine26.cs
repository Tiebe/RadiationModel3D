
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine26 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine26";
        public override double halfLife { get; } = 0.0082d;
        public override double atomicWeight { get; } = 26.02004d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon26() } },

        };
    }
}
    
    