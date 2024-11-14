using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium106";
        public override double halfLife { get; } = 0.179d;
        public override double atomicWeight { get; } = 105.93693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7452700.0), new Niobium106() } },

        };
    }
}
    
    