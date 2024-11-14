using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium229";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 229.03496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1872000.0), new Actinium229() } },

        };
    }
}
    
    