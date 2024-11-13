
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium115";
        public override double halfLife { get; } = 192456.0d;
        public override double atomicWeight { get; } = 114.90544d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium115() } },

        };
    }
}
    
    