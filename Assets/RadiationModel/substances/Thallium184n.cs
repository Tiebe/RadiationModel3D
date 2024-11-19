using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium184n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium184n";
        public override double halfLife { get; } = 0.0471d;
        public override double atomicWeight { get; } = 183.98236d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((453000.0, 0.00274)), new Thallium184() } },
            { 0.00089d, new List<RadioactiveSubstance> { new AlphaParticle(7793002.09), new Gold180() } },

        };
    }
}
    
    