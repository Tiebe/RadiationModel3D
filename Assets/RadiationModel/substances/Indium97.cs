
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium97";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 96.94912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium97() } },

        };
    }
}
    
    