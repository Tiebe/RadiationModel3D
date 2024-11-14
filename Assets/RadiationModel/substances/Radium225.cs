using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium225";
        public override double halfLife { get; } = 1280448.0d;
        public override double atomicWeight { get; } = 225.02361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 356000.0), new Actinium225() } },

        };
    }
}
    
    