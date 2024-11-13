
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium106";
        public override double halfLife { get; } = 372.0d;
        public override double atomicWeight { get; } = 105.91346d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium106() } },

        };
    }
}
    
    