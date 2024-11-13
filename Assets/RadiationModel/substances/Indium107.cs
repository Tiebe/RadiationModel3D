
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium107";
        public override double halfLife { get; } = 1944.0d;
        public override double atomicWeight { get; } = 106.91029d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium107() } },

        };
    }
}
    
    