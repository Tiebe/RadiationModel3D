
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium163";
        public override double halfLife { get; } = 4500.0d;
        public override double atomicWeight { get; } = 162.93004d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium163() } },

        };
    }
}
    
    