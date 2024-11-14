using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium164";
        public override double halfLife { get; } = 4.16d;
        public override double atomicWeight { get; } = 163.94285d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6461600.0), new Gadolinium164() } },

        };
    }
}
    
    