using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium152";
        public override double halfLife { get; } = 426555320.184d;
        public override double atomicWeight { get; } = 151.92175d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7208d, new List<RadioactiveSubstance> { new BetaParticle(1, 1874500.0), new Samarium152() } },
            { 0.2792d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1818800.0), new Gadolinium152() } },

        };
    }
}
    
    