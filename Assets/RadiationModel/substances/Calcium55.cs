using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium55";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 54.97998d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12190000.0), new Scandium55() } },

        };
    }
}
    
    