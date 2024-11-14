using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium162";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 161.93696d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5558100.0), new Gadolinium162() } },

        };
    }
}
    
    