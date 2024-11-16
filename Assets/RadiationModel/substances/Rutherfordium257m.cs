using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium257m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium257m";
        public override double halfLife { get; } = 4.5d;
        public override double atomicWeight { get; } = 257.103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.885d, new List<RadioactiveSubstance> { new AlphaParticle(10176047.4), new Nobelium253() } },
            { 0.115d, new List<RadioactiveSubstance> { new BetaParticle(1, 3270000.0), new Lawrencium257() } },

        };
    }
}
    
    