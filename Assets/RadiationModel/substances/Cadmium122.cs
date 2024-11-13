
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium122";
        public override double halfLife { get; } = 5.24d;
        public override double atomicWeight { get; } = 121.91346d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium122() } },

        };
    }
}
    
    