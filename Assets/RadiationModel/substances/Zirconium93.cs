using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium93";
        public override double halfLife { get; } = 50806692720000.01d;
        public override double atomicWeight { get; } = 92.90647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 90800.0), new Niobium93() } },

        };
    }
}
    
    