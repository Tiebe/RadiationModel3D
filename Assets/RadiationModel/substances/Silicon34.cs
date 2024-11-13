
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon34 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon34";
        public override double halfLife { get; } = 2.77d;
        public override double atomicWeight { get; } = 33.97854d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus34() } },

        };
    }
}
    
    